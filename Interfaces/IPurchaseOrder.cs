namespace FashionShop.Interfaces
{
    public interface IPurchaseOrder
    {
        public string GetErrors();

        PaginatedList<DonHang> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5);
        DonHang GetItem(int id); // read particular item

        bool Create(DonHang DonHang);
        bool Edit(DonHang DonHang);
        bool Delete(DonHang DonHang);

        public bool IsMaDonHangExists(string MaDonHang);
        public bool IsMaDonHangExists(string MaDonHang, int Id);

        public bool IsMaBaoGiaExists(string quoNumber);
        public bool IsMaBaoGiaExists(string quoNumber, int Id);
        public string GetNewMaDonHang();
    }
}
