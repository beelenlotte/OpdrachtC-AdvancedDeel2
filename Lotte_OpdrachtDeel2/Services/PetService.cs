using Lotte_OpdrachtDeel2.Db;
using Lotte_OpdrachtDeel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Services
{
    public class PetService
    {
        public Pet GetPet(int petId)
        {
            using (var db = new PetDbContext())
            {
                var pet = db.Pets.FirstOrDefault(x => x.Id == petId);
                return pet;
            }
        }

        public void CreatePet(Pet newPet)
        {
            using (var db = new PetDbContext())
            {
                db.Add(newPet);
                db.SaveChanges();
            }
        }


        public Pet UpdatePet(int petIdToEdit, Pet UpdatePetValues)
        {
            using (var db = new PetDbContext())
            {

                var petToEdit = db.Pets.First(pet => pet.Id == petIdToEdit);
                petToEdit.Id = UpdatePetValues.Id;
                petToEdit.Name = UpdatePetValues.Name;
                petToEdit.DateOfBirth = UpdatePetValues.DateOfBirth;
                db.SaveChanges();
                return petToEdit;
            }
        }

        public void DeletePetById(int petId)
        {
            using (var db = new PetDbContext())
            {
                var petToDelete = db.Pets.Find(petId);
                db.Pets.Remove(petToDelete);
                db.SaveChanges();
            }

        }
    }
}
