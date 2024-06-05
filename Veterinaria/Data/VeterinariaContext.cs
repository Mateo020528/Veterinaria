using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;
namespace Veterinaria.Data
{
    public class VeterinariaContext : DbContext {
        public VeterinariaContext(DbContextOptions<VeterinariaContext> options) : base(options){

        }
        //Agregamos los modelos 
         public DbSet<Owner> Owners {get; set;}
         public DbSet< Pet> Pets {get; set; }
         public DbSet<Quote> Quotes {get; set; }
         public DbSet<Vet> Vets {get; set; }
        
    }
}