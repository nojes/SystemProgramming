using System;
using App.Entities;

namespace App.Models
{
    public class Good
    {
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public string ManufacturerName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public decimal GoodCount { get; set; }

        public override string ToString()
        {
            return $"{GoodId,-2} {GoodName,-25} {ManufacturerName,-10} {CategoryName,10} {Price,10} {GoodCount,10}";
        }
    }
}
