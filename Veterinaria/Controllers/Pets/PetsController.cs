using Veterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Services.Pets;

namespace Veterinaria.Controllers.Pets
{
    [ApiController]
    [Route("Pets")]
    public class PetsController : ControllerBase
    {
        private readonly IPetsRepository _petsRepository;
        public PetsController(IPetsRepository petsRepository)
        {
            _petsRepository = petsRepository;
        }
        [HttpGet]
        public IEnumerable <Pet> GetPets()
        {
            return _petsRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Pet Details (int id)
        {
            return _petsRepository.GetById(id);
        }

        [HttpPost]
        public IActionResult CreatePet (Pet pet)
        {
            try{
                _petsRepository.Add(pet);

                return Ok("The has Created Successfully");
            }
            catch
            {
                return StatusCode (500, "Bad Request");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePet (Pet pet){
            try{
                _petsRepository.Update(pet);
                return Ok("The pet has been Update Successfully");
            }
            catch
            {
                return StatusCode (500, "Bad Request");
            }
        }


    }
}