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
        [Route("/addperson")]
        public IActionResult AddPerson([FromBody] Person person)
        {
         _personService.AddPerson(person);
            return Ok("ajout du participant dans la base");
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Route("/getAllPerson")]
        public IActionResult GetAllPerson()
        {
            var result = _personService.GetAllPeople();
            return Ok(result);
        }
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Route("/deleteperson")]
        public IActionResult DeletePerson([FromBody] Person person)
        {
            _personService.DeletePerson(person);
            return Ok("supression du participant dans la base");
        }
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [Route("/updateperson")]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            _personService.UpdatePerson(person);
            return Ok("modification du participant dans la base");
        }
    }

}
