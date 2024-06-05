using System.Text.Json.Serialization;

namespace Veterinaria.Models{
    public class Pet{
        public int Id {get; set;}
        public string Name {get; set;}
        public string Specie {get; set;}
        public string Race {get; set; }
        public DateOnly DateBirth {get; set;}
        public int OwnerId {get; set; }
        public Owner Owner {get; set; } //Llamamos a la tabla Propietarios
        public string Photo {get; set;}
        [JsonIgnore]
        public List<Quote> Quotes {get; set;}
    }
}