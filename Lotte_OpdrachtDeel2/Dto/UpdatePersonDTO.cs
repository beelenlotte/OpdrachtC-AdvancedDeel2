using System;

namespace Lotte_OpdrachtDeel2.Controllers
{
    public class UpdatePersonDTO
    {
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Password { get;  set; }
        public string Email { get;  set; }
        public DateTime DateOfBirth { get;  set; }
    }
}