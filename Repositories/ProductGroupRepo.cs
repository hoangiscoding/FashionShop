
namespace FashionShop.Repositories
{
    public class ProductGroupRepo : IProductGroup
    {
        private readonly InventoryContext _context; // for connecting to efcore.
        public ProductGroupRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public ProductGroup Create(ProductGroup ProductGroup)
        {
            _context.NhomSP.Add(ProductGroup);
            _context.SaveChanges();
            return ProductGroup;
        }

        public ProductGroup Delete(ProductGroup ProductGroup)
        {
            _context.NhomSP.Attach(ProductGroup);
            _context.Entry(ProductGroup).State = EntityState.Deleted;
            _context.SaveChanges();
            return ProductGroup;
        }

        public ProductGroup Edit(ProductGroup ProductGroup)
        {
            _context.NhomSP.Attach(ProductGroup);
            _context.Entry(ProductGroup).State = EntityState.Modified;
            _context.SaveChanges();
            return ProductGroup;
        }


        private List<ProductGroup> DoSort(List<ProductGroup> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.TenNhom).ToList();
                else
                    items = items.OrderByDescending(n => n.TenNhom).ToList();
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

        public PaginatedList<ProductGroup> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
            List<ProductGroup> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.NhomSP.Where(n => n.TenNhom.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .ToList();
            }
            else
                items = _context.NhomSP.ToList();

            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<ProductGroup> retItems = new PaginatedList<ProductGroup>(items, pageIndex, pageSize);

            return retItems;
        }

        public ProductGroup GetItem(int id)
        {
            ProductGroup item = _context.NhomSP.Where(u => u.MaNhomSP == id.ToString()).FirstOrDefault();
            return item;
        }
        public bool IsItemExists(string name)
        {
            int ct = _context.NhomSP.Where(n => n.TenNhom.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsItemExists(string name, int Id)
        {
            int ct = _context.NhomSP.Where(n => n.TenNhom.ToLower() == name.ToLower() && n.MaNhomSP != Id.ToString()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

    }
}
