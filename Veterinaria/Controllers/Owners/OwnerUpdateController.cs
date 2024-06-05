using Veterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Services.Owners;

namespace Veterinaria.Controllers.Owners
{
   
    public class OwnersUpdateController : ControllerBase
    {
    private readonly IOwnersRepository _ownersRepository;
        public OwnersUpdateController(IOwnersRepository ownersRepository)
        {
            _ownersRepository = ownersRepository;
        }
        [HttpPut]
        [Route("/Update/Owner")]
        public IActionResult Update ([FromBody] Owner owner )
        {
            if(owner != null)
            {
                _ownersRepository.Update(owner);
                return Ok();
            }
            else
            {
                return StatusCode (500,"Bad Request");
            }
            
        }
    }
}