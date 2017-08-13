using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks.ViewModels
{
    public class ProductsViewModel
    {
        public int ProductID { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductSubcategoryName { get; set; }
        public string ProductModelName { get; set; }
        public string ProductName { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }

    }
}