﻿namespace FashionShop.Controllers
{
    [Authorize]
    public class ProductGroupController : Controller
    {

        private readonly IProductGroup _Repo;
        public ProductGroupController(IProductGroup repo) // here the repository will be passed by the dependency injection.
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

            PaginatedList<ProductGroup> items = _Repo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);


            var pager = new PagerModel(items.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;


            return View(items);
        }


        public IActionResult Create()
        {
            ProductGroup item = new ProductGroup();
            return View(item);
        }

        [HttpPost]
        public IActionResult Create(ProductGroup item)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (item.MoTa.Length < 4 || item.MoTa == null)
                    errMessage = "MoTa Must be atleast 4 Characters";

                if (_Repo.IsItemExists(item.TenNhom) == true)
                    errMessage = errMessage + " " + " Name " + item.TenNhom + " Exists Already";

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
                TempData["SuccessMessage"] = "" + item.TenNhom + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(int id) //Read
        {
            ProductGroup item = _Repo.GetItem(id);
            return View(item);
        }


        public IActionResult Edit(int id)
        {
            ProductGroup item = _Repo.GetItem(id);
            TempData.Keep();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ProductGroup item)
        {
            bool bolret = false;
            string errMessage = "";

            try
            {
                if (item.MoTa.Length < 4 || item.MoTa == null)
                    errMessage = "MoTa Must be atleast 4 Characters";

                if (_Repo.IsItemExists(item.TenNhom, int.Parse(item.MaNhomSP)) == true)
                    errMessage = errMessage + item.TenNhom + " Already Exists";

                if (errMessage == "")
                {
                    item = _Repo.Edit(item);
                    TempData["SuccessMessage"] = item.TenNhom + ", Saved Successfully";
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
            ProductGroup item = _Repo.GetItem(id);
            TempData.Keep();
            return View(item);
        }


        [HttpPost]
        public IActionResult Delete(ProductGroup item)
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

            TempData["SuccessMessage"] = int.Parse(item.MaNhomSP) + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }


    }
}

