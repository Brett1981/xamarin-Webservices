using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Webservices.Models
{
    public class WebservicesContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebservicesContext() : base("name=WebservicesContext")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //base.Configuration.ProxyCreationEnabled = false;
        }

        public System.Data.Entity.DbSet<Webservices.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<Webservices.Models.Departement> Departements { get; set; }

        public System.Data.Entity.DbSet<Webservices.Models.Materiel> Materiels { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
