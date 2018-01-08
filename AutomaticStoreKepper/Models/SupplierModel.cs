using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutomaticStoreKepper.Models
{
    public class SupplierModel
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }

    }
}