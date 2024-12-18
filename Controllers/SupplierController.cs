﻿namespace FashionShop.Controllers
{
    [Authorize]
    public class SupplierController : Controller
    {

        private readonly ISupplier _repo;
        public SupplierController(ISupplier repo) // here the repository will be passed by the dependency injection.
        {
            _repo = repo;
        }

        [AcceptVerbs("Get","Post")]
        public JsonResult IsEmailExists(string EmailId,int Id=0)
        {
            bool isexists = _repo.IsSupplierEmailExists(EmailId,Id);

            if (isexists)
                return Json(data: false);
            else
                return Json(data: true);
        }
 


        public IActionResult Index(string sortExpression = "", string SearchText = "", int pg = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("code");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;

            ViewBag.SearchText = SearchText;
            PaginatedList<Supplier> NhaCungCap = _repo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);

            var pager = new PagerModel(NhaCungCap.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;
            return View(NhaCungCap);
        }


        public IActionResult Create()
        {
            Supplier supplier = new Supplier();
            return View(supplier);
        }

        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {                
                if (_repo.IsSupplierCodeExists(supplier.MaNCC) == true)
                    errMessage = errMessage + " " + " Supplier Code " + supplier.MaNCC + " Exists Already";

                if (_repo.IsSupplierNameExists(supplier.TenNCC) == true)
                    errMessage = errMessage + " " + " Supplier Name " + supplier.TenNCC + " Exists Already";

                if (_repo.IsSupplierEmailExists(supplier.Email) == true)
                    errMessage = errMessage + " " + " Supplier Email " + supplier.Email + " Exists Already";

                if (errMessage == "")
                {
                    supplier = _repo.Create(supplier);
                    bolret = true;
                }
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }
            if (bolret == false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(supplier);
            }
            else
            {
                TempData["SuccessMessage"] = "Supplier " + supplier.TenNCC + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id) //Read
        {
            Supplier supplier = _repo.GetItem(id);
            return View(supplier);
        }


        public IActionResult Edit(int id)
        {
            Supplier supplier = _repo.GetItem(id);
            TempData.Keep();
            return View(supplier);                                 
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (_repo.IsSupplierCodeExists(supplier.MaNCC) == true)
                    errMessage = errMessage + " " + " Supplier Code " + supplier.MaNCC + " Exists Already";

                if (_repo.IsSupplierNameExists(supplier.TenNCC) == true)
                    errMessage = errMessage + " " + " Supplier Name " + supplier.TenNCC + " Exists Already";

                if (_repo.IsSupplierEmailExists(supplier.Email) == true)
                    errMessage = errMessage + " " + " Supplier Email " + supplier.Email + " Exists Already";
                if (errMessage == "")
                {
                    supplier = _repo.Edit(supplier);
                    TempData["SuccessMessage"] = supplier.TenNCC + ", Supplier Saved Successfully";
                    bolret = true;
                }                               
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }
            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];
            if (bolret == false)
            {
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(supplier);
            }
            else
                return RedirectToAction(nameof(Index), new { pg = currentPage });
        }

        public IActionResult Delete(int id)
        {
            Supplier supplier = _repo.GetItem(id);
            TempData.Keep();
            return View(supplier);
        }


        [HttpPost]
        public IActionResult Delete(Supplier supplier)
        {
            try
            {
                supplier = _repo.Delete(supplier);
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(supplier);
            }

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = "Supplier " + supplier.TenNCC + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }


    }
}
