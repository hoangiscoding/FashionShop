namespace FashionShop.Repositories
{
    public class PurchaseOrderRepo : IPurchaseOrder
    {
        private string _errors = "";

        public string GetErrors()
        {
            return _errors;
        }


        private readonly InventoryContext _context; // for connecting to efcore.
        public PurchaseOrderRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public bool Create(DonHang DonHang)
        {
            bool retVal = false;
            _errors = "";

            try
            {
                _context.DonHang.Add(DonHang);
                _context.SaveChanges();
                retVal = true;
            }
            catch (Exception ex)
            {
                _errors = "Create Failed - Sql Exception Occured , Error Info : " + ex.Message;
            }
            return retVal;
        }

        public bool Delete(DonHang DonHang)
        {
            bool retVal = false;
            _errors = "";

            try
            {
                _context.Attach(DonHang);
                _context.Entry(DonHang).State = EntityState.Deleted;
                _context.SaveChanges();
                retVal = true;
            }
            catch (Exception ex)
            {
                _errors = "Delete Failed - Sql Exception Occured , Error Info : " + ex.Message;
            }
            return retVal;
        }

        public bool Edit(DonHang DonHang)
        {
            bool retVal = false;
            _errors = "";

            try
            {

                List<PoDetail> ChiTietDonHang = _context.ChiTietDonHang.Where(d => d.MaDonHang == DonHang.MaDonHang).ToList();
                _context.ChiTietDonHang.RemoveRange(ChiTietDonHang);
                _context.SaveChanges();

                _context.Attach(DonHang);
                _context.Entry(DonHang).State = EntityState.Modified;
                _context.ChiTietDonHang.AddRange(DonHang.ChiTietDonHang);
                _context.SaveChanges();


                retVal = true;
            }
            catch (Exception ex)
            {
                _errors = "Update Failed - Sql Exception Occured , Error Info : " + ex.Message;
            }
            return retVal;
        }




        private List<DonHang> DoSort(List<DonHang> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "MaDonHang")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.MaDonHang).ToList();
                else
                    items = items.OrderByDescending(n => n.MaDonHang).ToList();
            }
            else if (SortProperty.ToLower() == "MaBaoGia")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.MaBaoGia).ToList();
                else
                    items = items.OrderByDescending(n => n.MaBaoGia).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderByDescending(d => d.MaDonHang).ToList();
                else
                    items = items.OrderBy(d => d.MaDonHang).ToList();
            }

            return items;
        }

        public PaginatedList<DonHang> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
            List<DonHang> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.DonHang.Where(n => n.MaDonHang.Contains(SearchText) || n.MaBaoGia.Contains(SearchText))
                    .Include(s => s.Supplier)
                    .Include(c => c.BaseCurrency)
                    .Include(f => f.POCurrency)
                    .ToList();
            }
            else
                items = _context.DonHang
                   .Include(s => s.Supplier)
                   .Include(c => c.BaseCurrency)
                   .Include(f => f.POCurrency)
                   .ToList();




            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<DonHang> retItems = new PaginatedList<DonHang>(items, pageIndex, pageSize);

            return retItems;
        }

        public DonHang GetItem(int Id)
        {
            DonHang item = _context.DonHang.Where(i => i.MaDonHang == Id.ToString())
                     .Include(d => d.ChiTietDonHang)
                     .ThenInclude(i => i.Product)
                     .ThenInclude(u => u.DonVi)
                     .FirstOrDefault();


            item.ChiTietDonHang.ForEach(i => i.UnitName = i.Product.DonVi.TenDonVi);
            item.ChiTietDonHang.ForEach(p => p.MoTa = p.Product.MoTa);
            item.ChiTietDonHang.ForEach(p => p.Total = p.SoLuong * p.PrcInBaseCur);

            return item;
        }

        public bool IsMaDonHangExists(string MaDonHang)
        {
            int ct = _context.DonHang.Where(n => n.MaDonHang.ToLower() == MaDonHang.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsMaDonHangExists(string MaDonHang, int Id = 0)
        {
            if (Id == 0)
                return IsMaDonHangExists(MaDonHang);

            var poHeads = _context.DonHang.Where(n => n.MaDonHang == MaDonHang).Max(cd => cd.MaDonHang);
            if (poHeads == null || poHeads == MaDonHang)
                return false;
            else
                return true;
        }

        public bool IsMaBaoGiaExists(string MaBaoGia)
        {
            int ct = _context.DonHang.Where(n => n.MaBaoGia.ToLower() == MaBaoGia.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
        public bool IsMaBaoGiaExists(string MaBaoGia, int Id = 0)
        {
            if (Id == 0)
                return IsMaBaoGiaExists(MaBaoGia);

            var strQuotNo = _context.DonHang.Where(n => n.MaBaoGia == MaBaoGia).Max(nm => nm.MaDonHang);
            if (strQuotNo == null || strQuotNo == Id.ToString()) 
                return false;
            else
                return true;
        }
        public string GetNewMaDonHang()
        {

            string MaDonHang = "";
            var LastMaDonHang = _context.DonHang.Max(cd => cd.MaDonHang);

            if (LastMaDonHang == null)
                MaDonHang = "PO00001";
            else
            {
                int lastdigit = 1;
                int.TryParse(LastMaDonHang.Substring(2, 5).ToString(), out lastdigit);


                MaDonHang = "PO" + (lastdigit + 1).ToString().PadLeft(5, '0');
            }


            return MaDonHang;

        }
    }
}
