﻿
namespace FashionShop.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {

        private readonly IBrand _Repo;
        public BrandController(IBrand repo) // here the repository will be passed by the dependency injection.
        {
            _Repo = repo;
        }


        public IActionResult Index(string sortExpression = "", string SearchText = "", int pg = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("name");
            sortModel.AddColumn("MoTa");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;

            ViewBag.SearchText = SearchText;

            PaginatedList<Brand> items = _Repo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);


            var pager = new PagerModel(items.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;


            return View(items);
        }


        public IActionResult Create()
        {
            Brand item = new Brand();
            return View(item);
        }

        [HttpPost]
        public IActionResult Create(Brand item)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (item.MoTa.Length < 4 || item.MoTa == null)
                    errMessage = "MoTa Must be atleast 4 Characters";

                if (_Repo.IsItemExists(item.TenThuongHieu) == true)
                    errMessage = errMessage + " " + " Name " + item.TenThuongHieu + " Exists Already";

                if (errMessage == "")
                {
                    item = _Repo.Create(item);
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
                return View(item);
            }
            else
            {
                TempData["SuccessMessage"] = "" + item.TenThuongHieu + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id) //Read
        {
            Brand item = _Repo.GetItem(id);
            return View(item);
        }


        public IActionResult Edit(int id)
        {
            Brand item = _Repo.GetItem(id);
            TempData.Keep();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Brand item)
        {
            bool bolret = false;
            string errMessage = "";

            try
            {
                if (item.MoTa.Length < 4 || item.MoTa == null)
                    errMessage = "MoTa Must be atleast 4 Characters";

                if (_Repo.IsItemExists(item.TenThuongHieu, int.Parse(item.MaThuongHieu)) == true)
                    errMessage = errMessage + item.TenThuongHieu + " Already Exists";

                if (errMessage == "")
                {
                    item = _Repo.Edit(item);
                    TempData["SuccessMessage"] = item.TenThuongHieu + ", Saved Successfully";
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
                return View(item);
            }
            else
                return RedirectToAction(nameof(Index), new { pg = currentPage });
        }

        public IActionResult Delete(int id)
        {
            Brand item = _Repo.GetItem(id);
            TempData.Keep();
            return View(item);
        }


        [HttpPost]
        public IActionResult Delete(Brand item)
        {
            try
            {
                item = _Repo.Delete(item);
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(item);

            }

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = item.TenThuongHieu + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }


    }
}
