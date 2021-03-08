using Lotte_OpdrachtDeel2.Dto;
using Lotte_OpdrachtDeel2.Models;
using Lotte_OpdrachtDeel2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lotte_OpdrachtDeel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        PersonService personService = new PersonService();

        [HttpGet("GetMyPets")]
        public ActionResult<Person> GetAllPets(int personId)
        {
            var petsPerson = personService.GetAllPets(personId);
            return Ok(petsPerson);
        }



        [HttpPost]
        public ActionResult CreateNewPerson(CreatePersonDTO newPerson)
        {
            var person = new Person();
            person.FirstName = newPerson.FirstName;
            person.LastName = newPerson.LastName;
            person.Password = newPerson.Password;
            person.Email = newPerson.Email;
            person.DateOfBirth = newPerson.DateOfBirth;
            personService.CreatePerson(person);
            return Ok();
        }

        [HttpDelete]
        public ActionResult<Person> DeletePersonById(int personId)
        {
            personService.DeletePersonById(personId);
            return Ok();
        }
    }
}
