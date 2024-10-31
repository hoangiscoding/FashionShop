

namespace FashionShop.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {

        private readonly IWebHostEnvironment _webHost;

        private readonly IBrand _brandRepo;
        private readonly ICategory _categoryRepo;        
        private readonly IProductGroup _productGroupRepo;
        private readonly IProductProfile _productProfileRepo;




        private readonly IUnit _unitRepo;
        private readonly IProduct _productRepo;
        public ProductController(IProduct productrepo,IUnit unitrepo, IBrand brandRepo, ICategory categoryRepo, IProductGroup productGroupRepo, IProductProfile productProfileRepo, IWebHostEnvironment webHost) // here the repository will be passed by the dependency injection.
        {

            _webHost = webHost;

            _productRepo = productrepo;
            _unitRepo = unitrepo;


            _brandRepo = brandRepo;
            _categoryRepo = categoryRepo;


            _productGroupRepo = productGroupRepo;
            _productProfileRepo = productProfileRepo;


        }


        public IActionResult Index(string sortExpression = "", string SearchText = "", int pg = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();

            sortModel.AddColumn("Code");
            sortModel.AddColumn("image");
            sortModel.AddColumn("name");
            sortModel.AddColumn("MoTa");
            sortModel.AddColumn("DonGiaNhap");
            sortModel.AddColumn("DonGiaBan");
            sortModel.AddColumn("DonVi");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;

            ViewBag.SearchText = SearchText;

            PaginatedList<Product> SanPham = _productRepo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);



            var pager = new PagerModel(SanPham.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;


            return View(SanPham);
        }


        private void PopulateViewbags()
        {

            ViewBag.DonVi = GetDonVi();

            ViewBag.ThuongHieu = GetThuongHieu();

            ViewBag.DanhMuc = GetDanhMuc();

            ViewBag.NhomSP = GetNhomSP();

            ViewBag.HoSoSP = GetHoSoSP();

        }

        public IActionResult Create()
        {
            Product product = new Product();

            PopulateViewbags();


            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            bool bolret = false;
            string errMessage = "";
            try
            {
                if (product.MoTa.Length < 4 || product.MoTa == null)
                    errMessage = "Product MoTa Must be atleast 4 Characters";



                if (_productRepo.IsItemCodeExists(product.MaSP) == true)
                    errMessage = errMessage + " " + " Product Code " + product.MaSP + " Exists Already";



                if (_productRepo.IsItemExists(product.TenSP) == true)
                    errMessage = errMessage + " " + " Product Name " + product.TenSP + " Exists Already";

                if (errMessage == "")
                {

                    string uniqueFileName = GetUploadedFileName(product);
                    product.Anh = uniqueFileName;


                    product = _productRepo.Create(product);
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
                PopulateViewbags();       
                return View(product);

                //return RedirectToAction(nameof(Create));
            }
            else
            {
                TempData["SuccessMessage"] = "Product " + product.TenSP + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Details(string id) //Read
        {
            Product product = _productRepo.GetItem(id);
            return View(product);
        }


        public IActionResult Edit(string id)
        {
            Product product = _productRepo.GetItem(id);
            ViewBag.DonVi = GetDonVi();

         
            ViewBag.ThuongHieu = GetThuongHieu();

            ViewBag.DanhMuc = GetDanhMuc();

            ViewBag.NhomSP = GetNhomSP();

            ViewBag.HoSoSP = GetHoSoSP();

            TempData.Keep();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool bolret = false;
            string errMessage = "";

            try
            {
                if (product.MoTa.Length < 4 || product.MoTa == null)
                    errMessage = "Product MoTa Must be atleast 4 Characters";


                if (_productRepo.IsItemCodeExists(product.TenSP, product.MaSP) == true)
                    errMessage = errMessage + " " + " Product Code " + product.MaSP + " Exists Already";

                if (_productRepo.IsItemExists(product.TenSP, product.MaSP) == true)
                    errMessage = errMessage + "Product Name " + product.TenSP + " Already Exists";

                if (product.ProductPhoto != null)
                {
                    string uniqueFileName = GetUploadedFileName(product);
                    product.Anh = uniqueFileName;
                }

                if (errMessage == "")
                {
                    product = _productRepo.Edit(product);
                    TempData["SuccessMessage"] = product.TenSP + ", product Saved Successfully";
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
                return View(product);
            }
            else
                return RedirectToAction(nameof(Index), new { pg = currentPage });
        }

        public IActionResult Delete(string id)
        {
            Product product = _productRepo.GetItem(id);
            TempData.Keep();
            return View(product);
        }


        [HttpPost]
        public IActionResult Delete(Product product)
        {
            try
            {
                product = _productRepo.Delete(product);
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                if (ex.InnerException != null)
                    errMessage = ex.InnerException.Message;

                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(product);
            }

            int currentPage = 1;
            if (TempData["CurrentPage"] != null)
                currentPage = (int)TempData["CurrentPage"];

            TempData["SuccessMessage"] = "Product " + product.TenSP + " Deleted Successfully";
            return RedirectToAction(nameof(Index), new { pg = currentPage });


        }



        private List<SelectListItem> GetDonVi()
        {
            var lstDonVi = new List<SelectListItem>();

            PaginatedList<Unit> DonVi = _unitRepo.GetItems("Name", SortOrder.Ascending,"",1,1000);
            lstDonVi = DonVi.Select(ut => new SelectListItem()
            {
                Value = ut.MaDonVi.ToString(),
                Text = ut.TenDonVi
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value="",
                Text="----Select Unit----"
            };

            lstDonVi.Insert(0, defItem);
            
            return lstDonVi;        
        }

        private List<SelectListItem> GetThuongHieu()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<Brand> items = _brandRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.MaThuongHieu.ToString(),
                Text = ut.TenThuongHieu
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Brand----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }


        private List<SelectListItem> GetDanhMuc()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<Category> items = _categoryRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.MaDanhMuc.ToString(),
                Text = ut.TenDanhMuc
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Category----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }

        private List<SelectListItem> GetNhomSP()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<ProductGroup> items = _productGroupRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.MaNhomSP.ToString(),
                Text = ut.TenNhom
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select ProductGroup----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }


        private List<SelectListItem> GetHoSoSP()
        {
            var lstItems = new List<SelectListItem>();

            PaginatedList<ProductProfile> items = _productProfileRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);
            lstItems = items.Select(ut => new SelectListItem()
            {
                Value = ut.MaHoSoSP.ToString(),
                Text = ut.TenHoSoSP
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select ProductProfile----"
            };

            lstItems.Insert(0, defItem);

            return lstItems;
        }



        private string GetUploadedFileName(Product product)
        {
            string uniqueFileName = null;

            if (product.ProductPhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ProductPhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    product.ProductPhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        [AcceptVerbs("Get","Post")]
        public JsonResult IsMaSPValid(string Code,string Name="")
        {

            bool isExists = _productRepo.IsItemCodeExists(Code,Name);

            if (isExists)
                return Json(data: false);
            else
                return Json(data: true);
        }


        [AcceptVerbs("Get", "Post")]
        public JsonResult IsProductNameValid(string Name,string Code="")
        {

            bool isExists = _productRepo.IsItemExists(Name,Code);

            if (isExists)
                return Json(data: false);
            else
                return Json(data: true);
        }




    }
}
