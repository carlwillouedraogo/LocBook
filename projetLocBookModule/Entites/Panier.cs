using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    public class Panier
    {
        private static Panier instance;
        private IList<Entites.Ouvrage> ouvrages;

        public static Panier GetInstance()
        {
            if (instance == null)
            {
                instance = new Panier();
            }
            return instance;
        }

        private Panier()
        {
            ouvrages = new List<Ouvrage>();
        }

        public void AjouterAuPanier(Entites.Ouvrage ouvrage)
        {
            ouvrages.Add(ouvrage);
        }

       public IList<Entites.Ouvrage> GetPanier()
        {
            return ouvrages;
        }

        public void deletePanier()
        {
            ouvrages.Clear();
        }
    }
}
