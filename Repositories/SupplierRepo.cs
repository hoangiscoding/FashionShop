

namespace FashionShop.Repositories
{
    public class SupplierRepo : ISupplier
    {
        private readonly InventoryContext _context;
        public SupplierRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }

        public Supplier Create(Supplier supplier)
        {
            _context.NhaCungCap.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public Supplier Delete(Supplier supplier)
        {
            _context.NhaCungCap.Attach(supplier);
            _context.Entry(supplier).State = EntityState.Deleted;
            _context.SaveChanges();
            return supplier;
        }

        public Supplier Edit(Supplier supplier)
        {
            _context.NhaCungCap.Attach(supplier);
            _context.Entry(supplier).State = EntityState.Modified;
            _context.SaveChanges();
            return supplier;
        }

        public Supplier GetItem(int id)
        {
            Supplier supplier = _context.NhaCungCap.Where(s => int.Parse(s.MaNCC) == id).FirstOrDefault();
            return supplier;
        }

        private List<Supplier> DoSort(List<Supplier> NhaCungCap, string SortProperty, SortOrder sortOrder)
        {
            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    NhaCungCap = NhaCungCap.OrderBy(n => n.TenNCC).ToList();
                else
                    NhaCungCap = NhaCungCap.OrderByDescending(n => n.TenNCC).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    NhaCungCap = NhaCungCap.OrderBy(d => d.MaNCC).ToList();
                else
                    NhaCungCap = NhaCungCap.OrderByDescending(d => d.MaNCC).ToList();
            }

            return NhaCungCap;
        }

        public PaginatedList<Supplier> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {

            List<Supplier> NhaCungCap;

            if (SearchText != "" && SearchText != null)
            {
                NhaCungCap = _context.NhaCungCap.Where(n => n.TenNCC.Contains(SearchText) || n.MaNCC.Contains(SearchText))
                    .ToList();
            }
            else
                NhaCungCap = _context.NhaCungCap.ToList();

            NhaCungCap = DoSort(NhaCungCap, SortProperty, sortOrder);

            PaginatedList<Supplier> retNhaCungCap = new PaginatedList<Supplier>(NhaCungCap, pageIndex, pageSize);

            return retNhaCungCap;

        }

        public bool IsSupplierCodeExists(string code)
        {
            
            int ct = _context.NhaCungCap.Where(s => s.MaNCC.ToLower() == code.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;

        }
        public bool IsSupplierCodeExists(string code, int Id)
        {
            int ct = _context.NhaCungCap.Where(s => s.MaNCC.ToLower() == code.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;

        }
        public bool IsSupplierEmailExists(string email)
        {
            int ct = _context.NhaCungCap.Where(s => s.Email.ToLower() == email.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;

        }
        public bool IsSupplierEmailExists(string email, int Id)
        {
            int ct = _context.NhaCungCap.Where(s => s.Email.ToLower() == email.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
        public bool IsSupplierNameExists(string name)
        {
            int ct = _context.NhaCungCap.Where(s => s.TenNCC.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;

        }
        public bool IsSupplierNameExists(string name, int Id)
        {
            int ct = _context.NhaCungCap.Where(s => s.TenNCC.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
    }
}
