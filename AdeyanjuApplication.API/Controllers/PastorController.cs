using AdeyanjuApplication.API.Commands.PastorCommands;
using AdeyanjuApplication.API.Queries.PastorQueries;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Request;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;
using ChurchApplication.API.Commands.PastorCommands;
using ChurchApplication.Entities.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdeyanjuApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PastorController : BaseController
    {
        public PastorController(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllPastorQuery();

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetPastorByIdQuery(id);

            var result = await _mediator.Send(query);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddPastor([FromBody] CreatePastor pastor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new CreatePastorInfoRequest(pastor);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {pastorId = result.Id }, result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdatePastor([FromBody] UpdatePastor pastor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new UpdatePastorInfoRequest(pastor);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePastor (string Id)
        {
            var command = new DeletePastorInfoRequest(Id);
            var result = await _mediator.Send(command);

            return result ? NoContent(): BadRequest();  
        }

    }
}
