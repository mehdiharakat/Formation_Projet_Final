﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class foodtruckEntities : DbContext
    {
        public foodtruckEntities()
            : base("name=foodtruckEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actualite> Actualites { get; set; }
        public virtual DbSet<Adresse_facturation> Adresse_facturation { get; set; }
        public virtual DbSet<Adresse_livraison> Adresse_livraison { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<commentaire> commentaires { get; set; }
        public virtual DbSet<FamilleRepa> FamilleRepas { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Ligne_Commande> Ligne_Commande { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Profil> Profils { get; set; }
        public virtual DbSet<Repa> Repas { get; set; }
        public virtual DbSet<Societe> Societes { get; set; }
        public virtual DbSet<StatutCommande> StatutCommandes { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<FamilleRepas_Repas> FamilleRepas_Repas { get; set; }
        public virtual DbSet<ProfilUtilisateur> ProfilUtilisateurs { get; set; }
    }
}
