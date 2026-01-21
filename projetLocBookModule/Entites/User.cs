using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    class User
    {
        public long id { get; set; }
        public string email { get; set; }
        public string use_role { get; set; }
        public string password { get; set; }
    }
}
