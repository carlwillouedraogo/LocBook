using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    public class Membre
    {
        public long mem_id { get; set; }
        public string mem_nom { get; set; }
        public string mem_prenom { get; set; }
        public int mem_age { get; set; }
        public long mem_use_id { get; set; }
        public string email { get; set; }
    }
}
