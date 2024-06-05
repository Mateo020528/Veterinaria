using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Services.Owners;

namespace Veterinaria.Controllers.Owners
{
  
    public class OwnersCreatedController : ControllerBase
    {
        private readonly IOwnersRepository _ownerRepository;
        public OwnersCreatedController(IOwnersRepository ownersRepository)
        {
            _ownerRepository = ownersRepository;
        }
        [HttpPost]
        [Route("Owners/Create")]
        public IActionResult Create ([FromBody]Owner owner)
        {
            try 
            {
                _ownerRepository.Add(owner);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Bad Request");
            }
            
        }
    }
}