using Microsoft.AspNetCore.Mvc;

namespace FashionShop.Controllers
{
    [Authorize]
    public class PurchaseOrderController : Controller
    {

        private readonly IPurchaseOrder _Repo;

        private readonly IProduct _ProductRepo;


        private readonly ISupplier _SupplierRepo;

        private readonly ICurrency _CurrencyRepo;



        public PurchaseOrderController(IPurchaseOrder repo, IProduct productRepo, ISupplier supplierRepo, ICurrency currencyRepo)
        {
            _Repo = repo;
            _ProductRepo = productRepo;

            _SupplierRepo = supplierRepo;
            _CurrencyRepo = currencyRepo;


        }

        public IActionResult Index(string sortExpression = "", string SearchText = "", int pg = 1, int pageSize = 5)
        {
            SortModel sortModel = new SortModel();
            sortModel.AddColumn("Id");
            sortModel.AddColumn("MaDonHang");
            sortModel.AddColumn("NgayTao");
            sortModel.ApplySort(sortExpression);
            ViewData["sortModel"] = sortModel;

            ViewBag.SearchText = SearchText;

            PaginatedList<DonHang> items = _Repo.GetItems(sortModel.SortedProperty, sortModel.SortedOrder, SearchText, pg, pageSize);


            var pager = new PagerModel(items.TotalRecords, pg, pageSize);
            pager.SortExpression = sortExpression;
            this.ViewBag.Pager = pager;


            TempData["CurrentPage"] = pg;
            return View(items);
        }

        public IActionResult Create()
        {
            DonHang item = new DonHang();
            item.ChiTietDonHang.Add(new PoDetail() { MaChiTietDonHang = "1" });
            ViewBag.ProductList = GetSanPham();
            ViewBag.SupplierList = GetNhaCungCap();
            ViewBag.PoCurrencyList = GetPoTienTe();
            ViewBag.BaseCurrencyList = GetBaseTienTe();
            ViewBag.TyGiaHoiDoai = GetTyGiaHoiDoai();
            item.MaDonHang = _Repo.GetNewMaDonHang();
            //GetNhaCungCap()


            //ViewBag.MaTraoDoiTienTe = GetCurrencyList();

            return View(item);
        }

        [HttpPost]
        public IActionResult Create(DonHang item)
        {
            item.ChiTietDonHang.RemoveAll(a => a.SoLuong == 0);


            bool bolret = false;
            string errMessage = "";
            try
            {
                bolret = _Repo.Create(item);
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }


            if (bolret == false)
            {
                errMessage = errMessage + " " + _Repo.GetErrors();

                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(item);
            }
            else
            {
                TempData["SuccessMessage"] = "" + item.MaDonHang + " Created Successfully";
                return RedirectToAction(nameof(Index));
            }
        }


        public IActionResult Details(int id)
        {
            DonHang item = _Repo.GetItem(id);

            ViewBag.ProductList = GetSanPham();
            ViewBag.SupplierList = GetNhaCungCap();
            ViewBag.PoCurrencyList = GetPoTienTe();
            ViewBag.BaseCurrencyList = GetBaseTienTe();

            return View(item);
        }

        private List<SelectListItem> GetSanPham()
        {
            var lstSanPham = new List<SelectListItem>();

            PaginatedList<Product> SanPham = _ProductRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);

            lstSanPham = SanPham.Select(ut => new SelectListItem()
            {
                Value = ut.MaSP.ToString(),
                Text = ut.TenSP
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Product----"
            };

            lstSanPham.Insert(0, defItem);

            return lstSanPham;
        }


        private List<SelectListItem> GetNhaCungCap()
        {
            var lstNhaCungCap = new List<SelectListItem>();

            PaginatedList<Supplier> NhaCungCap = _SupplierRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);

            lstNhaCungCap = NhaCungCap.Select(sp => new SelectListItem()
            {
                Value = sp.MaNCC.ToString(),
                Text = sp.TenNCC
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Supplier ----"
            };

            lstNhaCungCap.Insert(0, defItem);

            return lstNhaCungCap;
        }


        private List<SelectListItem> GetPoTienTe()
        {
            var lstTienTe = new List<SelectListItem>();

            PaginatedList<Currency> TienTe = _CurrencyRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);

            lstTienTe = TienTe.Select(sp => new SelectListItem()
            {
                Value = sp.MaTienTe.ToString(),
                Text = sp.TenTienTe
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select PO Currency ----"
            };

            lstTienTe.Insert(0, defItem);

            return lstTienTe;
        }


        private List<SelectListItem> GetBaseTienTe()
        {
            var lstTienTe = new List<SelectListItem>();

            PaginatedList<Currency> TienTe = _CurrencyRepo.GetItems("Name", SortOrder.Ascending, "AED", 1, 1000);

            lstTienTe = TienTe.Select(sp => new SelectListItem()
            {
                Value = sp.MaTienTe.ToString(),
                Text = sp.TenTienTe
            }).ToList();

            //var defItem = new SelectListItem()
            //{
            //    Value = "",
            //    Text = "----Select Base Currency ----"
            //};

            //lstTienTe.Insert(0, defItem);

            return lstTienTe;
        }
        private List<SelectListItem> GetTyGiaHoiDoai()
        {
            var lstTienTe = new List<SelectListItem>();

            PaginatedList<Currency> TienTe = _CurrencyRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);

            lstTienTe = TienTe.Select(sp => new SelectListItem()
            {
                Value = sp.MaTienTe.ToString(),
                Text = sp.TyGiaHoiDoai.ToString()
            }).ToList();

            return lstTienTe;
        }
        private List<SelectListItem> GetUnitNames()
        {
            var lstSanPham = new List<SelectListItem>();

            PaginatedList<Product> SanPham = _ProductRepo.GetItems("Name", SortOrder.Ascending, "", 1, 1000);

            lstSanPham = SanPham.Select(ut => new SelectListItem()
            {
                Value = ut.MaSP.ToString(),
                Text = ut.DonVi.TenDonVi
            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Unit----"
            };

            lstSanPham.Insert(0, defItem);

            return lstSanPham;
        }


        public IActionResult Edit(int id)
        {
            DonHang item = _Repo.GetItem(id);

            ViewBag.ProductList = GetSanPham();
            ViewBag.SupplierList = GetNhaCungCap();
            ViewBag.PoCurrencyList = GetPoTienTe();
            ViewBag.BaseCurrencyList = GetBaseTienTe();
            ViewBag.TyGiaHoiDoai = GetTyGiaHoiDoai();
            ViewBag.UnitNames = GetUnitNames();

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(DonHang item)
        {
            item.ChiTietDonHang.RemoveAll(a => a.SoLuong == 0);


            bool bolret = false;
            string errMessage = "";
            try
            {
                bolret = _Repo.Edit(item);
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }


            if (bolret == false)
            {
                errMessage = errMessage + " " + _Repo.GetErrors();

                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(item);
            }
            else
            {
                TempData["SuccessMessage"] = "" + item.MaDonHang + " Modified Successfully";
                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult Delete(int id)
        {
            DonHang item = _Repo.GetItem(id);

            ViewBag.ProductList = GetSanPham();
            ViewBag.SupplierList = GetNhaCungCap();
            ViewBag.PoCurrencyList = GetPoTienTe();
            ViewBag.BaseCurrencyList = GetBaseTienTe();


            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(DonHang item)
        {
            item.ChiTietDonHang.RemoveAll(a => a.SoLuong == 0);


            bool bolret = false;
            string errMessage = "";
            try
            {
                bolret = _Repo.Delete(item);
            }
            catch (Exception ex)
            {
                errMessage = errMessage + " " + ex.Message;
            }


            if (bolret == false)
            {
                errMessage = errMessage + " " + _Repo.GetErrors();

                TempData["ErrorMessage"] = errMessage;
                ModelState.AddModelError("", errMessage);
                return View(item);
            }
            else
            {
                TempData["SuccessMessage"] = "" + item.MaDonHang + " Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
