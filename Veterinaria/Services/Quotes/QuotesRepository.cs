using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Services.Quotes
{
    public class QuotesRepository : IQuotesRepository
    {
          private readonly VeterinariaContext _context;
        public QuotesRepository(VeterinariaContext context )
        {
            _context = context;
        }      
        
        public void Add(Quote quote)
        {
            _context.Quotes.Add(quote);
            _context.SaveChanges();
        }
        public IEnumerable<Quote> GetAll()
        {
            return _context.Quotes.ToList();
        }

        public Quote GetById(int id)
        {
            return _context.Quotes.Find(id);
        }

        public void Update(Quote quote)
        {
            _context.Quotes.Update(quote);
            _context.SaveChanges();
        }
    }
}