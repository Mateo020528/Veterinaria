using Veterinaria.Models;

namespace Veterinaria.Services.Pets
{
    public interface IPetsRepository
    {
        public IEnumerable <Pet> GetAll();
        public Pet GetById (int id);
        void Add (Pet pet);
        void Update (Pet pet);

    }
}