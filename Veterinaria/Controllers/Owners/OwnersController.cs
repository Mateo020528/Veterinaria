using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Services.Owners;

namespace Veterinaria.Controllers.Owners
{
    public class OwnersController : ControllerBase
    {
        private readonly IOwnersRepository _ownersRepository;
        public OwnersController(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }
        [HttpGet]
        [Route("Owners")]
        //Listamos todos los Dueños
        public IEnumerable <Owner> GetOwners()
        {
            return _ownersRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Owner Details (int id)
        {            
             return _ownersRepository.GetById(id);     
        }
        

    }
}