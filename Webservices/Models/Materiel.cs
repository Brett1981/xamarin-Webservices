using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webservices.Models
{
    public class Materiel
    {
        public Materiel()
        {
            this.Departements = new HashSet<Departement>();
        }
        public int MaterielId { get; set; }

        public String libelle { get; set; }

        public virtual ICollection<Departement> Departements { get; set; }
    }
}