
namespace FashionShop.Repositories
{
    public class UnitRepository : IUnit
    {
        private readonly InventoryContext _context; // for connecting to efcore.
        public UnitRepository(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public Unit Create(Unit unit)
        {
            _context.DonVi.Add(unit);
            _context.SaveChanges();
            return unit;
        }

        public Unit Delete(Unit unit)
        {
            _context.DonVi.Attach(unit);
            _context.Entry(unit).State = EntityState.Deleted;
            _context.SaveChanges();
            return unit;
        }

        public Unit Edit(Unit unit)
        {
            _context.DonVi.Attach(unit);
            _context.Entry(unit).State = EntityState.Modified;
            _context.SaveChanges();
            return unit;
        }


        private List<Unit> DoSort(List<Unit> DonVi, string SortProperty, SortOrder sortOrder)
        {           

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    DonVi = DonVi.OrderBy(n => n.TenDonVi).ToList();
                else
                    DonVi = DonVi.OrderByDescending(n => n.TenDonVi).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    DonVi = DonVi.OrderBy(d => d.MoTa).ToList();
                else
                    DonVi = DonVi.OrderByDescending(d => d.MoTa).ToList();
            }

            return DonVi;
        }

        public PaginatedList<Unit> GetItems(string SortProperty, SortOrder sortOrder,string SearchText="",int pageIndex=1,int pageSize=5)
        {
            List<Unit> DonVi;

            if (SearchText != "" && SearchText!=null)
            {
                DonVi = _context.DonVi.Where(n => n.TenDonVi.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .ToList();            
            }
            else
                DonVi= _context.DonVi.ToList();

            DonVi = DoSort(DonVi,SortProperty,sortOrder);
            
            PaginatedList<Unit> retDonVi = new PaginatedList<Unit>(DonVi, pageIndex, pageSize);

            return retDonVi;
        }

        public Unit GetUnit(int id)
        {
            Unit unit = _context.DonVi.Where(u => u.MaDonVi == id.ToString()).FirstOrDefault();
            return unit;
        }
        public bool IsUnitNameExists(string name)
        {
            int ct = _context.DonVi.Where(n => n.TenDonVi.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;      
        }

        public bool IsUnitNameExists(string name,int Id)
        {
            int ct = _context.DonVi.Where(n => n.TenDonVi.ToLower() == name.ToLower() && int.Parse(n.MaDonVi) !=Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

    }
}
