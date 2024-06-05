using Veterinaria.Models;

namespace Veterinaria.Services.Vets
{
    public interface IVetsRepository
    {
        public IEnumerable <Vet> GetAll ();

        public Vet GetById (int id);
       
    }
}