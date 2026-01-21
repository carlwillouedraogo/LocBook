using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    class Emprunt
    {
        public string ouv_titre { get; set; }
        public double ouv_prix { get; set; }
        public DateTime emp_date_debut { get; set; }
        public DateTime emp_date_fin { get; set; }
    }
}
