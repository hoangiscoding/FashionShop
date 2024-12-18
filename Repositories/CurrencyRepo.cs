﻿namespace FashionShop.Repositories
{
    public class CurrencyRepo : ICurrency
    {
        private readonly InventoryContext _context; // for connecting to efcore.

        private string _errors = "";


        public CurrencyRepo(InventoryContext context) // will be passed by dependency injection.
        {
            _context = context;
        }

        public bool Create(Currency currency)
        {
            try
            {

                //check the entity against rules list.
                //1. rule 
                if (!IsMoTaValid(currency)) return false;

                //2. rule
                if (IsItemExists(currency.TenTienTe)) return false;                    

                
                _context.TienTe.Add(currency);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errors = "Create Failed - Sql Exception Occured , Error Info : " + ex.Message;
                return false;
            }                                
        }

        public bool Delete(Currency currency)
        {
            try
            {
                _context.TienTe.Attach(currency);
                _context.Entry(currency).State = EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                if(ex.InnerException !=null)
                    _errors = "Delete Failed - Sql Exception Occured , Error Info : " + ex.InnerException.Message;
                else
                _errors = "Delete Failed - Sql Exception Occured , Error Info : " + ex.Message;
                return false;
            }
        }

        public bool Edit(Currency currency)
        {
            try
            {
                //check the entity against rules list.
                //1. rule 
                if (!IsMoTaValid(currency)) return false;

                //2. rule
                if (IsItemExists(currency.TenTienTe, int.Parse(currency.MaTienTe))) return false;

                _context.TienTe.Attach(currency);
                _context.Entry(currency).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _errors = "Update Failed - Sql Exception Occured , Error Info : " + ex.Message;
                return false;
            }
        }

        public string GetErrors()
        {
            return _errors;
        }

        private List<Currency> DoSort(List<Currency> items, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    items = items.OrderBy(n => n.TenTienTe).ToList();
                else
                    items = items.OrderByDescending(n => n.TenTienTe).ToList();
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

        public Currency GetItem(int id)
        {
            Currency item = _context.TienTe.Where(u => u.MaTienTe == id.ToString()).FirstOrDefault();
            return item;
        }

        public PaginatedList<Currency> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5)
        {
       
            List<Currency> items;

            if (SearchText != "" && SearchText != null)
            {
                items = _context.TienTe.Where(n => n.TenTienTe.Contains(SearchText) || n.MoTa.Contains(SearchText))
                    .ToList();
            }
            else
                items = _context.TienTe.ToList();

            items = DoSort(items, SortProperty, sortOrder);

            PaginatedList<Currency> retItems = new PaginatedList<Currency>(items, pageIndex, pageSize);

            return retItems;

        }


        //Rules List
        public bool IsCurrencyCombExists(int srcCurrencyId, int excCurrencyId)
        {
            int ct = _context.TienTe.Where(n => n.MaTienTe==srcCurrencyId.ToString() && n.MaTraoDoiTienTe== excCurrencyId.ToString()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsItemExists(string name)
        {
            int ct = _context.TienTe.Where(n => n.TenTienTe.ToLower() == name.ToLower()).Count();
            if (ct > 0)
            {
                _errors= " Name " + name + " Exists Already";
                return true;
            }
            else
                return false;
        }

        public bool IsItemExists(string name, int id)
        {
            int ct = _context.TienTe.Where(n => n.TenTienTe.ToLower() == name.ToLower() && n.MaTienTe != id.ToString()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        private bool IsMoTaValid(Currency item)
        {
            if (item.MoTa.Length < 4 || item.MoTa == null)
            {
                _errors = "MoTa Must be atleast 4 Characters";
                return false;
            }
            return true;
        }



    }
}
