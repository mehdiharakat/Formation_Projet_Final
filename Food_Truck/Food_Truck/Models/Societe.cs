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
    
    public partial class Societe
    {
        public int id_Societe { get; set; }
        public string code_postal { get; set; }
        public string nom_Societe { get; set; }
        public Nullable<int> num_rue { get; set; }
        public string num_siren { get; set; }
        public string num_siret { get; set; }
        public string pays { get; set; }
        public string rue { get; set; }
        public string ville { get; set; }
    }
}