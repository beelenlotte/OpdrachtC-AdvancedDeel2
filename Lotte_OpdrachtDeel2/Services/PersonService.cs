using Lotte_OpdrachtDeel2.Db;
using Lotte_OpdrachtDeel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Services
{
    public class PersonService
    {
        public Person GetPerson(int personId)
        {
            using var db = new PersonDbContext();
            var person = db.Persons.FirstOrDefault(x => x.Id == personId);
            return person;
        }

        public List<Pet> GetAllPets(int personId)
        {
            using var db = new PersonDbContext();
            var personpets = db.Pets.Where(x => x.Id == personId).ToList();
            return personpets;
        }




        public void CreatePerson(Person NewPerson)
        {
            using var db = new PersonDbContext();
            db.Add(NewPerson);
            db.SaveChanges();
        }

        public Person UpdatePerson(int personIdToEdit, Person UpdatePersonValues)
        {
            using var db = new PersonDbContext();
            var PersonToEdit = db.Persons.First(person => person.Id == personIdToEdit);
            PersonToEdit.FirstName = UpdatePersonValues.FirstName;
            PersonToEdit.LastName = UpdatePersonValues.LastName;
            PersonToEdit.House = UpdatePersonValues.House;
            PersonToEdit.Pets = UpdatePersonValues.Pets;
            PersonToEdit.Password = UpdatePersonValues.Password;
            PersonToEdit.Email = UpdatePersonValues.Email;

            db.SaveChanges();
            return PersonToEdit;
        }


        public Person ChangePassword(int personIdPasswordChange,  Person password)
        {
            using var db = new PersonDbContext();
            var newPassword = db.Persons.First(person => person.Id == personIdPasswordChange);
            newPassword.Password = password.Password;
            db.SaveChanges();
            return newPassword;

        }

        public void DeletePersonById(int personId)
        {
            using var db = new PersonDbContext();
            var personToDelete = db.Persons.Find(personId);
            db.Persons.Remove(personToDelete);
            db.SaveChanges();
        }

        
       public Person Login(string email, string password)
        {
            using var db = new PersonDbContext();
            var login = db.Persons.FirstOrDefault(person => person.Email == email);
            login.Email = email;
            //login.Password = password;
            db.SaveChanges();
            return login;
        }
    }
}
