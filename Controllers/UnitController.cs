
namespace FashionShop.Controllers
{
    [Authorize]
    public class UnitController : Controller
    {       
        
        private readonly IUnit _unitRepo;
        public UnitController(IUnit unitrepo) // here the repository will be passed by the dependency injection.
        {            
            _unitRepo = unitrepo;
        }

      
        public IActionResult Index(string sortExpression="", string SearchText = "",int pg=1,int pageSize=5) 
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("MoTa");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;
            
            ViewBag.SearchText = SearchText;

            PaginatedList<Unit> DonVi = _unitRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder,SearchText,pg,pageSize);            
            

            var pager = new PagerModel(DonVi.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;


            return View(DonVi);
        }


        public IActionResult Create()
        {
            Unit unit = new Unit();
            return View(unit);
        }

        [HttpPost]  
        public IActionResult Create(Unit unit)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (unit.MoTa.Length < 4 || unit.MoTa == null)               
                    errMessage = "Unit MoTa Must be atleast 4 Characters";

                if (_unitRepo.IsUnitNameExists(unit.TenDonVi) == true)
                    errMessage = errMessage + " " + " Unit Name " + unit.TenDonVi +" Exists Already";

                if (errMessage == "")
                {
                    unit = _unitRepo.Create(unit);
                    bolret = true;
                }                
            }
            catch(Exception ex) 
            {
                errMessage = errMessage + " " + ex.Message;
            }
            if (bolret == false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(unit);
            }
            else
            {
                TempData["SuccessMessage"] = "Unit " + unit.TenDonVi + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id) //Read
        {
            Unit unit =_unitRepo.GetUnit(id);              
            return View(unit);        
        }


        public IActionResult Edit(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            TempData.Keep();
            return View(unit);
        }  
        
        [HttpPost]
        public IActionResult Edit(Unit unit)
        {
            bool bolret = false;
            string errMessage = "";

            try
            {
                if (unit.MoTa.Length < 4 || unit.MoTa == null)                
                   errMessage = "Unit MoTa Must be atleast 4 Characters";

                if (_unitRepo.IsUnitNameExists(unit.TenDonVi, int.Parse(unit.MaDonVi)) == true)
                    errMessage = errMessage + "Unit Name " + unit.TenDonVi + " Already Exists";

                if (errMessage == "")
                {
                    unit = _unitRepo.Edit(unit);
                    TempData["SuccessMessage"] = unit.TenDonVi + ", Unit Saved Successfully";
                    bolret = true;
                }
            }
            catch(Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;                
            }

          

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

          
            if(bolret==false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(unit);
            }
            else
            return RedirectToAction(nameof(Index),new {pg=currentPage});
        }

        public IActionResult Delete(int id)
        {
            Unit unit = _unitRepo.GetUnit(id);
            TempData.Keep();
            return View(unit);
        }

        
        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                unit = _unitRepo.Delete(unit);
            }
            catch(Exception ex)
            {
                string errMessage = ex.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(unit);
            }          
            
            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = "Unit " + unit.TenDonVi + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }

     
    }
}
