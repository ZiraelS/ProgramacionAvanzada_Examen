using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks.ViewModels
{
    public class SalesViewModel
    {
        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string SalesOrderNumber { get; set; }
        public decimal TotalDue { get; set; }

    }
}