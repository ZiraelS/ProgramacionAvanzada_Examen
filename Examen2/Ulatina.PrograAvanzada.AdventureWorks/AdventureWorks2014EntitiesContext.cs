using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ulatina.PrograAvanzada.AdventureWorks
{
    public class AdventureWorks2014EntitiesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AdventureWorks2014EntitiesContext() : base("name=AdventureWorks2014EntitiesContext")
        {
        }

        public System.Data.Entity.DbSet<Ulatina.PrograAvanzada.AW.Model.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Ulatina.PrograAvanzada.AW.Model.ProductModel> ProductModels { get; set; }

        public System.Data.Entity.DbSet<Ulatina.PrograAvanzada.AW.Model.ProductSubcategory> ProductSubcategories { get; set; }
    }
}
