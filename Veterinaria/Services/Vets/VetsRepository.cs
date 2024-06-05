using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Services.Vets
{
    public class VetsRepository : IVetsRepository
    {
        private readonly VeterinariaContext _context;
        public VetsRepository(VeterinariaContext context)
        {
            _context = context;
        }

        public IEnumerable<Vet> GetAll()
        {
            return _context.Vets.ToList();
        }
        public Vet GetById(int id)
        {
            return _context.Vets.Find(id);
        }

    }
}