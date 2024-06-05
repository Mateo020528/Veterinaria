namespace Veterinaria.Models{
    public class Quote{
        public int Id {get; set; }
        public DateOnly Date {get; set;}
        public int PetId {get; set; }
        public Pet Pet {get; set;}   //Llamamos  a la tabla Mascotas
        public int VetId {get; set;}
        public Vet Vet {get; set;}
        public string Description {get; set;}

    }
}