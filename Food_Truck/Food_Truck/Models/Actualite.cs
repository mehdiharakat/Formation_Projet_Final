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
    
    public partial class Actualite
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date_de_creation { get; set; }
        public Nullable<System.DateTime> date_de_validite { get; set; }
        public string description { get; set; }
        public string imageurl { get; set; }
        public string title { get; set; }
        public Nullable<int> Utilisateur_creation { get; set; }
    }
}
