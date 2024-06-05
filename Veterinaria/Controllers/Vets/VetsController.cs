using Veterinaria.Models;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Services.Vets;

namespace Veterinaria.Controllers.Vets
{
    
    public class VetsController : ControllerBase
    {
        private readonly IVetsRepository _vetsRepository;
        public VetsController(IVetsRepository vetsRepository)
        {
            _vetsRepository = vetsRepository;
        }
        [HttpGet]
        [Route("/Vets/")]
        public IEnumerable <Vet> GetVet (){

            return _vetsRepository.GetAll();
        }
        [HttpGet]
        [Route("/Vets/{id}")]
        public Vet GetById(int id)
        {
            return _vetsRepository.GetById(id);
        }

    }
}