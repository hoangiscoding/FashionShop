


namespace FashionShop.Repositories
{
    public class CategoryRepo : ICategory
    {
        private readonly InventoryContext _context; // for connecting to efcore.
        public CategoryRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public Category Create(Category category)
        {
            _context.DanhMuc.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Delete(Category category)
        {
            _context.DanhMuc.Attach(category);
            _context.Entry(category).State = EntityState.Deleted;
            _context.SaveChanges();
            return category;
        }

        public Category Edit(Category category)
        {
            _context.DanhMuc.Attach(category);
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
            return category;
        }


        private List<Category> DoSort(List<Category> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => int.Parse(n.MaDanhMuc)).ToList();
                else
                    items = items.OrderByDescending(n => int.Parse(n.MaDanhMuc)).ToList();
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

        public PaginatedList<Category> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
            List<Category> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.DanhMuc.Where(n => n.TenDanhMuc.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .ToList();
            }
            else
                items = _context.DanhMuc.ToList();

            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<Category> retItems = new PaginatedList<Category>(items, pageIndex, pageSize);

            return retItems;
        }

        public Category GetItem(int id)
        {
            Category item = _context.DanhMuc.Where(u => int.Parse(u.MaDanhMuc) == id).FirstOrDefault();
            return item;
        }
        public bool IsItemExists(string name)
        {
            int ct = _context.DanhMuc.Where(n => n.TenDanhMuc.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsItemExists(string name, int Id)
        {
            int ct = _context.DanhMuc.Where(n => n.TenDanhMuc.ToLower() == name.ToLower() && int.Parse(n.MaDanhMuc) != Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

    }
}
