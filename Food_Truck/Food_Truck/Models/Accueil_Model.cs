using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_Truck.Models
{
    public class Accueil_Model
    {
        public IEnumerable<Produit> produits { get; set; }

        public IEnumerable<Actualite> actualites { get; set; }

    }
}