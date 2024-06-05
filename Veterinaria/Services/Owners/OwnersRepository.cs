using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Services.Owners
{
    public class OwnersRepository : IOwnersRepository
    {
        private readonly VeterinariaContext _context;
        public OwnersRepository(VeterinariaContext context)
        {
            _context = context;
        }
        public void Add(Owner owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }
        public IEnumerable<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }

        public Owner GetById(int id)
        {
            return _context.Owners.Find(id);
        }
        public void Update(Owner owner)
        {
            _context.Owners.Update(owner);
            _context.SaveChanges();
        }
    }
}