using AutoMapper;
using Lotte_OpdrachtDeel2.Dto;
using Lotte_OpdrachtDeel2.Models;
using Lotte_OpdrachtDeel2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotte_OpdrachtDeel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseControllerAutoMapper : ControllerBase
    {
        private readonly IMapper _mapper;
        readonly HouseService houseService = new HouseService();
        public HouseControllerAutoMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<House> GetHouse(int houseId)
        {
            var house = houseService.GetHouse(houseId);
            return Ok(house);
        }

        [HttpGet("GetAllHousesByPostal")]
        public ActionResult<House> GetAllHousesByPostal(string postalCode)
        {
            var allhouses = houseService.GetAllHousesByPostal(postalCode);
            return Ok(allhouses);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateHouseDTO house)
        {
            var houseDTOMapped = _mapper.Map<House>(house);
            houseService.CreateHouse(houseDTOMapped);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(int HouseId, CreateHouseDTO house)
        {
            var houseDTOMapped = _mapper.Map<House>(house);
            houseService.UpdateHouse(HouseId, houseDTOMapped);
            return Ok();
        }



        [HttpDelete]
        public ActionResult<House> DeleteHouseById(int houseId)
        {
            houseService.DeleteHouseById(houseId);
            return Ok();
        }


    }
}
