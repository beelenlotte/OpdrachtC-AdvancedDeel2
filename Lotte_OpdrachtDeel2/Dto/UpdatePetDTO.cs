﻿using Lotte_OpdrachtDeel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Dto
{
    public class UpdatePetDTO
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PersonId { get; set; }

    }
}
