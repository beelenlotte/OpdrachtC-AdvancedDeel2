//using Lotte_OpdrachtDeel2.Dto;
//using Lotte_OpdrachtDeel2.Models;
//using Lotte_OpdrachtDeel2.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Lotte_OpdrachtDeel2.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class HouseController : ControllerBase
//    {
        
//        readonly HouseService houseService = new HouseService();

//        [HttpGet]
//        public ActionResult<House> GetHouse(int houseId)
//        {
//            var house = houseService.GetHouse(houseId);
//            return Ok(house);
//        }

//        [HttpGet("GetAllHousesByPostal")]
//        public ActionResult<House> GetAllHousesByPostal(string postalCode)
//        {
//            var allhouses = houseService.GetAllHousesByPostal(postalCode);
//            return Ok(allhouses);
//        }


//        [HttpPost]
//        public ActionResult CreateNewHouse(CreateHouseDTO newHouse)
//        {
//            var house = new House
//            {
//                StreetName = newHouse.StreetName,
//                HouseNumber = newHouse.HouseNumber,
//                PostalCode = newHouse.PostalCode,
//                City = newHouse.City
//            };
//            houseService.CreateHouse(house);
//            return Ok();
//        }


//        [HttpPut]
//        public ActionResult<House> UpdateHouse(int houseIdToEdit, UpdateHouseDTO housevalues)
//        {
//            var houseToUpdate = new House
//            {
//                StreetName = housevalues.StreetName,
//                HouseNumber = housevalues.HouseNumber,
//                PostalCode = housevalues.PostalCode,
//                City = housevalues.City
//            };
//            houseService.UpdateHouse(houseIdToEdit, houseToUpdate);
//            return Ok();
//        }

//        [HttpDelete]
//        public ActionResult<House> DeleteHouseById(int houseId)
//        {
//            houseService.DeleteHouseById(houseId);
//            return Ok();
//        }


//    }
//}
