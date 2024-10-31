namespace FashionShop.Repositories
{
    public class BrandRepo : IBrand
    {
        private readonly InventoryContext _context; // for connecting to efcore.
        public BrandRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public Brand Create(Brand Brand)
        {
            _context.ThuongHieu.Add(Brand);
            _context.SaveChanges();
            return Brand;
        }

        public Brand Delete(Brand Brand)
        {
            _context.ThuongHieu.Attach(Brand);
            _context.Entry(Brand).State = EntityState.Deleted;
            _context.SaveChanges();
            return Brand;
        }

        public Brand Edit(Brand Brand)
        {
            _context.ThuongHieu.Attach(Brand);
            _context.Entry(Brand).State = EntityState.Modified;
            _context.SaveChanges();
            return Brand;
        }


        private List<Brand> DoSort(List<Brand> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.TenThuongHieu).ToList();
                else
                    items = items.OrderByDescending(n => n.TenThuongHieu).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(d => d.MoTa).ToList();
                else
                    items = items.OrderByDescending(d => d.MoTa).ToList();
            }

            return items;
        }

        public PaginatedList<Brand> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
            List<Brand> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.ThuongHieu.Where(n => n.TenThuongHieu.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .ToList();
            }
            else
                items = _context.ThuongHieu.ToList();

            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<Brand> retItems = new PaginatedList<Brand>(items, pageIndex, pageSize);

            return retItems;
        }

        public Brand GetItem(int id)
        {
            Brand item = _context.ThuongHieu.Where(u => int.Parse(u.MaThuongHieu) == id).FirstOrDefault();
            return item;
        }
        public bool IsItemExists(string name)
        {
            int ct = _context.ThuongHieu.Where(n => n.TenThuongHieu.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsItemExists(string name, int Id)
        {
            int ct = _context.ThuongHieu.Where(n => n.TenThuongHieu.ToLower() == name.ToLower() && int.Parse(n.MaThuongHieu) != Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

    }
}
