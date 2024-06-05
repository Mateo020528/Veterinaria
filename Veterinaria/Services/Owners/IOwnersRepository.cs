using Veterinaria.Models;

namespace Veterinaria.Services.Owners
{
    public interface IOwnersRepository
    {
        public IEnumerable <Owner> GetAll(); // Listamos los propietarios / Dueños
        Owner GetById (int id); //Detalles 
        void Add (Owner owner); //Crear 
        void Update (Owner owner); //Actualizar
        
    }
}