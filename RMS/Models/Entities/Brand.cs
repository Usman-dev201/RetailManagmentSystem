﻿namespace RMS.Models.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public IList<Product> Products { get; }  = new List<Product>();
    }
}
