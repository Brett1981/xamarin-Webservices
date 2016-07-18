using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Departement
    {
        public Departement()
        {
            this.Employees = new HashSet<Employee>();
        }
        public int DepartementId { get; set; }

        public String Name { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}
