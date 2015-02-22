using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OefeningMVC_Programmeren5.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Category { get; set; }
        [Required]
        public string Naam { get; set; }
        public string LinkDatasheet { get; set; }
        public int Aantal { get; set; }
        public double AankoopPrijs { get; set; }
            
    }

    public class DbComponent : DbContext
    {
        public DbSet<Component> Componenten { get; set; }

    }
}