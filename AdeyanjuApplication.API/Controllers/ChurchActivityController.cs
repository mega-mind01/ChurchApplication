using AdeyanjuApplication.API.Commands.PastorCommands;
using AdeyanjuApplication.API.Controllers;
using AdeyanjuApplication.API.Queries.PastorQueries;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Request;
using AutoMapper;
using ChurchApplication.API.Commands.ChurchActivityCommands;
using ChurchApplication.API.Commands.PastorCommands;
using ChurchApplication.API.Queries.ChurchActivityQueries;
using ChurchApplication.Entities.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChurchApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChurchActivityController : BaseController
    {
        public ChurchActivityController(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllChurchActivityQuery();

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
            var query = new GetChurchActivityByIdQuery(id);

            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddChurchActivity([FromBody] CreateChurchActivity request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new CreateChurchActivityInfoRequest(request);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateChurchActivity([FromBody] UpdateChurchActivity request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new UpdateChurchActivityInfoRequest(request);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteChurchActivity(string Id)
        {
            var command = new DeleteChurchActivityInfoRequest(Id);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest();
        }
    }
}
