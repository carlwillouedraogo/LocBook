using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    class Reservation
    {
        public long res_liv_id { get; set; }
        public DateTime res_date_debut { get; set; }
        public DateTime res_date_fin { get; set; }
        public string ouv_titre { get; set; }
    }
}
