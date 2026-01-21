using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    public class Ouvrage
    {
        public long ouv_id { get; set; }
        public string ouv_titre { get; set; }
        public Double ouv_prix { get; set; }
        public int ouv_stock { get; set; }
        public string ouv_auteur { get; set; }
        public string gen_nom { get; set; }
        public string cat_nom { get; set; }
        public string bib_nom { get; set; }
    }
}
