using Lotte_OpdrachtDeel2.Db;
using Lotte_OpdrachtDeel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Services
{
    public class HouseService
    {
        public House GetHouse(int houseId)
        {
            using(var db = new HouseDbContext())
            {
                var house = db.Houses.FirstOrDefault(x => x.Id == houseId);
                return house;
            }
        }

        public List<House> GetAllHousesByPostal(string postalCode)
        {
            using (var db = new HouseDbContext())
            {

                var houses = db.Houses.Where(x => x.PostalCode == postalCode).ToList();
                return houses;
            }
        }

        public void CreateHouse(House Newhouse)
        {
            using (var db = new HouseDbContext())
            {
                db.Add(Newhouse);
                db.SaveChanges();
            }
        }

        public House UpdateHouse(int houseIdToEdit, House UpdatehouseValues)
        {
            using (var db = new HouseDbContext())
            {

                var HouseToEdit = db.Houses.First(house => house.Id == houseIdToEdit);
                HouseToEdit.StreetName = UpdatehouseValues.StreetName;
                HouseToEdit.HouseNumber = UpdatehouseValues.HouseNumber;
                HouseToEdit.PostalCode = UpdatehouseValues.PostalCode;
                HouseToEdit.City = UpdatehouseValues.City;
                HouseToEdit.Persons = UpdatehouseValues.Persons;
                db.SaveChanges();
                return HouseToEdit;
            }
        }
    
        public void DeleteHouseById(int houseId)
        {
            using (var db = new HouseDbContext())
            {
                var houseToDelete = db.Houses.Find(houseId);
                db.Houses.Remove(houseToDelete);
                db.SaveChanges();
            }
        }

    }
}
