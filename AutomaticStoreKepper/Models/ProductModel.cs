using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomaticStoreKepper.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int SuppliedId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime Created_On { get; set; }
        public int Creted_By { get; set; }
    }
}