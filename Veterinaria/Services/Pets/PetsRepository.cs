using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Services.Pets
{
    public class PetsRepository : IPetsRepository
    {
        private readonly VeterinariaContext _context;
        public PetsRepository(VeterinariaContext context)
        {
            _context = context;
        }
        public void Add(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges();
        }

        public IEnumerable<Pet> GetAll()
        {
            return _context.Pets.ToList();
        }

        public Pet GetById(int id)
        {
            return _context.Pets.Find(id);
        }

        public void Update(Pet pet)
        {
            _context.Pets.Update(pet);
            _context.SaveChanges();
        }
    }
}