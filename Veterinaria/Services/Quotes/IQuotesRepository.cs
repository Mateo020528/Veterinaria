using Veterinaria.Models;

namespace Veterinaria.Services.Quotes
{
    public interface IQuotesRepository
    {
        public IEnumerable <Quote> GetAll();
        public Quote GetById (int id);
        void Add(Quote quote);
        void Update (Quote quote);
    
    }
}