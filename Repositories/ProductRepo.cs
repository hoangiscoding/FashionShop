

namespace FashionShop.Repositories
{
    public class ProductRepo : IProduct
    {
        private readonly InventoryContext _context; // for connecting to efcore.
        public ProductRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public Product Create(Product Product)
        {
            _context.SanPham.Add(Product);
            _context.SaveChanges();
            return Product;
        }

        public Product Delete(Product Product)
        {
            Product = pGetItem(Product.MaSP);
            _context.SanPham.Attach(Product);
            _context.Entry(Product).State = EntityState.Deleted;
            _context.SaveChanges();
            return Product;
        }

        public Product Edit(Product Product)
        {
            _context.SanPham.Attach(Product);
            _context.Entry(Product).State = EntityState.Modified;
            _context.SaveChanges();
            return Product;
        }


        private List<Product> DoSort(List<Product> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.TenSP).ToList();
                else
                    items = items.OrderByDescending(n => n.TenSP).ToList();
            }
            else if (SortProperty.ToLower() == "code")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.MaSP).ToList();
                else
                    items = items.OrderByDescending(n => n.MaSP).ToList();
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

        public PaginatedList<Product> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
            List<Product> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.SanPham.Where(n => n.TenSP.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .Include(u=>u.DonVi)
                    .ToList();
            }
            else
                items = _context.SanPham.Include(u => u.DonVi).ToList();


            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<Product> retItems = new PaginatedList<Product>(items, pageIndex, pageSize);

            return retItems;
        }

        public Product GetItem(string Code)
        {
            Product item = _context.SanPham.Where(u => u.MaSP == Code)
                .Include(u=>u.DonVi)
                .FirstOrDefault();

            item.BreifPhotoName = GetBriefPhotoName(item.Anh);

            return item;
        }


        private string GetBriefPhotoName(string fileName)
        {
            if (fileName==null)
                return "";

            string[] words = fileName.Split('_');
            return words[words.Length - 1];        
        }

    

        public Product pGetItem(string Code)
        {
            Product item = _context.SanPham.Where(u => u.MaSP == Code)                
                .FirstOrDefault();
            return item;
        }
        public bool IsItemExists(string name)
        {
            int ct = _context.SanPham.Where(n => n.TenSP.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
        public bool IsItemExists(string name, string Code)
        {
            if (Code == "")
                return IsItemExists(name);
            var strCode = _context.SanPham.Where(n => n.TenSP == name).Max(cd => cd.MaSP);
            if (strCode == null || strCode == Code)
                return false;
            else           
                 return true;           
        }
        public bool IsItemCodeExists(string itemCode)
        {
            int ct = _context.SanPham.Where(n => n.MaSP.ToLower() == itemCode.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
        public bool IsItemCodeExists(string itemCode, string name)
        {
            if (name == "")
                return IsItemCodeExists(itemCode);
            var strName = _context.SanPham.Where(n => n.MaSP == itemCode).Max(nm => nm.TenSP);
            if (strName == null || strName == name)
                return false;
            else          
                return IsItemExists(name);                                         
        }
    }
}
