using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    class Achat
    {
        //public long ach_ouv_id { get; set; }
        public DateTime ach_date { get; set; }
        public double ouv_prix { get; set; }
        public string ouv_titre { get; set; }
    }
}
