using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Food_Truck.Models;
using System.Data.Entity;

namespace Food_Truck.Controllers
{
    public class AccueilController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            foodtruckEntities db = new foodtruckEntities();
            Accueil_Model model = new Accueil_Model();
            model.actualites = db.Actualites.ToList();
            var TopVentes = (from lc in db.Ligne_Commande
                                group lc by lc.id_Produit into LcGroup
                                select new
                                {
                                    produit = LcGroup.Key,
                                    TotalVente = LcGroup.Sum(x => x.quantite),
                                }).OrderByDescending(x=>x.TotalVente).Take(3).Select(y=>y.produit).ToList();


            model.produits = (from p in db.Produits
                               where TopVentes.Contains(p.id_Produit)
                               select p).ToList();
                               
                               

            return View(model);
        }
    }
}