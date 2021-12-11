using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoelByEsnParis.Models;
using NoelByEsnParis.Services.Interfaces;

namespace NoelByEsnParis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoelController : ControllerBase
    {
        private readonly IPersonService _personService;
        public NoelController(IPersonService noelService)
        {
            _personService = noelService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/addperson")]
        public IActionResult AddPerson([FromBody] Person person)
        {var result = _personService.AddPerson(person);
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
           var result= _personService.UpdatePerson(person);
            return Ok(result);
        }
    }

}
