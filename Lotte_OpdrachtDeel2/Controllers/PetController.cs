using Lotte_OpdrachtDeel2.Dto;
using Lotte_OpdrachtDeel2.Models;
using Lotte_OpdrachtDeel2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        readonly PetService petService = new PetService();

        

        //[HttpGet("GetAllPetsByType")]
        //public ActionResult<Pet> GetAllPetsByType(string petType)
        //{
        //    var type = 
        //    PetType = petType;

        //}


        [HttpGet]
        public ActionResult<Pet> GetPet(int petId)
        {
            var pet = petService.GetPet(petId);
            return Ok(pet);
        }

        [HttpPost]
        public ActionResult CreateNewPet(CreatePetDTO newPet)
        {
            var pet = new Pet
            {
                Name = newPet.Name,
                PersonId = newPet.PersonId,
                DateOfBirth = newPet.DateOfBirth
            };
            //pet.PetType = newPet.PetType;
            petService.CreatePet(pet);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Pet> UpdatePet(int petIdToEdit, UpdatePetDTO petvalues)
        {
            var petToUpdate = new Pet
            {
                Id = petvalues.PetId,
                Name = petvalues.Name,
                PersonId = petvalues.PersonId,
                DateOfBirth = petvalues.DateOfBirth
            };
            petService.UpdatePet(petIdToEdit, petToUpdate);
            return Ok();
        }

        [HttpDelete]
        public ActionResult<Pet> DeletePetById(int petId)
        {
            petService.DeletePetById(petId);
            return Ok();
        }
    }
}
