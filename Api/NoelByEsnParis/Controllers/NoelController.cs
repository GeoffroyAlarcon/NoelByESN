using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoelByEsnParis.Models;
using NoelByEsnParis.Services.Interfaces;
using System.Collections.Generic;

namespace NoelByEsnParis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoelController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IPersonCoupleWishService _personCoupleWishService;
        public NoelController(IPersonService noelService, IPersonCoupleWishService personCoupleWishService)
        {
            _personService = noelService;
            _personCoupleWishService = personCoupleWishService;

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/addperson")]
        public IActionResult AddPerson([FromBody] Person person)
        { var result = _personService.AddPerson(person);
            return Ok(result);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/getAllPerson")]
        public IActionResult GetAllPerson()
        {
            var result = _personService.GetAllPeople();
            return Ok(result);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/deleteperson/{personId}")]
        public IActionResult DeletePerson(int personId)
        {
            var result = _personService.DeletePerson(personId);
            return Ok(result);
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/updateperson")]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            var result = _personService.UpdatePerson(person);
            return Ok(result);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/generatelistpeoplewish")]
        public IActionResult generatelistpeoplewish([FromBody] List<Person> people)
        {
            var result = _personCoupleWishService.CadeauNoel(people);
            return Ok(result);
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/FindAllPairPeopleWish")]
        public IActionResult FindAllPairPeopleWish()
        {
            var result =_personCoupleWishService.FindAllPairPeopleWish();
            return Ok(result);
        }

    }

}
