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


        [HttpPut("ChangePassword")]
        public ActionResult<Person> ChangePassword(int personIdPasswordChange, UpdatePWPersonDTO password)
        {
            var newPassword = new Person();
            newPassword.Password = password.Password;
            personService.ChangePassword(personIdPasswordChange, newPassword);
            return Ok();
        }

        [HttpGet("Login")]
        public ActionResult<Person> Login(string email, string password)
        {
            bool LoginCorrect = false;
            var login = personService.Login(email, password);

            if(login.Email == email && login.Password == password)
            {
                LoginCorrect = true;
                return Ok(login);
            }
            else
            {
                LoginCorrect = false;
                return Unauthorized();
            }

            //if(LoginCorrect == true)
            //{
            //    return Ok(login);
            //}
            //else if(LoginCorrect == false)
            //{
            //    return Unauthorized();
            //}
        }

    }   
}
