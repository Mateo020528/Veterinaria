using System.Text.Json.Serialization;

namespace Veterinaria.Models{
    public class Owner
    {
        public int Id {get; set;}
        public string Names {get; set; }
        public string LastNames {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}
        public string Phone {get; set; }
        [JsonIgnore]
        public List<Pet> Pets {get; set;} //Enviamos la Lista Owner a la tabla Pet

    }
}