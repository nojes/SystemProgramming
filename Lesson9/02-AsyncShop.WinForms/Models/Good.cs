namespace _02_AsyncShop.WinForms.Models
{
    class Filter
    {
        public int ManufacturerId { get; set; }
        public int CategoryId { get; set; }
    }

    public class Good
    {
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public string ManufacturerName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal GoodCount { get; set; }
    }
}