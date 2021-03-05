﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Pet> Pets { get; set; }
        public int? HouseId { get; set; }
        public House House { get; set; }
    }
}
