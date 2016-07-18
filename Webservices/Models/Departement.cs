using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webservices.Models
{
    public class Departement
    {
        public Departement()
        {
            this.Employees = new HashSet<Employee>();
            this.Materiels = new HashSet<Materiel>();
        }
        public int DepartementId { get; set; }

        public String Name { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }




        public virtual ICollection<Materiel> Materiels { get; set; }
    }
}