using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Webservices.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public int? DepartementId { get; set; }
        [ForeignKey("DepartementId")]
        public virtual Departement Departement { get; set; }

    }
}