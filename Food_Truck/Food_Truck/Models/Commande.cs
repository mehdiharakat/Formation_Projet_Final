//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food_Truck.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        public int id_Commande { get; set; }
        public Nullable<System.DateTime> dateCommande { get; set; }
        public string num_facture { get; set; }
        public double prix_total { get; set; }
        public Nullable<int> id_Adresse_facturation { get; set; }
        public Nullable<int> id_Adresse_livraison { get; set; }
        public Nullable<int> id_StatutCommande { get; set; }
        public Nullable<int> id_Utilisateur { get; set; }
    }
}
