using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Services.Quotes;

namespace Veterinaria.Controllers.Quotes
{

    public class QuotesController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuotesController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }
        [HttpGet]
        [Route("Quotes")]
        public IEnumerable <Quote> GetQuotes()
        {
            return _quotesRepository.GetAll();
        }

        [HttpGet]
        [Route("/Quotes/{id}")]
        public Quote GetById (int id)
        {
            return _quotesRepository.GetById(id);
        }

        [HttpPost]
        [Route("/Quotes/")]
        public IActionResult Add ([FromBody] Quote quote)
        {
           try
           {
             _quotesRepository.Add(quote);
            return Ok ("Quote Has created Successfully");
           }
           catch 
           {
            return StatusCode (500, "Bad Request");
           }
        }

        [HttpPut("{id}")]
        public IActionResult Update (Quote quote)
        {
            try{
                _quotesRepository.Update(quote);
                return Ok("Quote Has Updated Successfully");
            }
            catch 
            {
                return StatusCode (500, "Bad Request");
            }
        }
     
        
    }
}