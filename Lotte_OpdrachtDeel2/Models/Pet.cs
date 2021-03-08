using Lotte_OpdrachtDeel2.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PersonId { get; set; }

        //public List<string> PetType = new List<string>();
        //public string[] PetType = new[]
        //{
        //    "Dog", "Cat", "Guinea Pig", "Fish", "Rabbit"
        //};

    }
}
