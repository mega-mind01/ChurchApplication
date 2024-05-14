using AdeyanjuApplication.API.Controllers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Request;
using AutoMapper;
using ChurchApplication.API.Commands.EvangelistCommands;
using ChurchApplication.API.Queries.EvangelistQueries;
using ChurchApplication.Entities.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChurchApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EvangelistController : BaseController
    {
        public EvangelistController(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllEvangelistQuery();

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
            var query = new GetEvangelistByIdQuery(id);

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateEvangelist([FromBody] CreateEvangelist createEvangelist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new CreateEvangelistInfoRequest(createEvangelist);
            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new {evangelsitId = result.Id }, result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateEvangelist([FromBody] UpdateEvangelist evangelist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new UpdateEvangelistInfoRequest(evangelist);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEvangelist (string Id)
        {
            var command = new DeleteEvangelistInfoRequest(Id);
            var result = await _mediator.Send(command);

            return result ? NoContent(): BadRequest();
        }
    }
}
