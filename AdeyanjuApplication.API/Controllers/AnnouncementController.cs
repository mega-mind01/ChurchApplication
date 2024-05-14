using AdeyanjuApplication.API.Controllers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Request;
using AutoMapper;
using ChurchApplication.API.Commands.AnnouncementCommands;
using ChurchApplication.API.Queries.AnnouncementQueries;
using ChurchApplication.Entities.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChurchApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AnnouncementController : BaseController
    {
        public AnnouncementController(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllAnnouncementQuery();

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById (string id)
        {
            var query = new GetAnnouncementByIdQuery(id);

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddAnnouncement([FromBody] CreateAnnouncement request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new CreateAnnouncementInfoRequest(request);

            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateAnnouncement([FromBody] UpdateAnnouncement updateAnnouncement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new UpdateAnnouncementInfoRequest(updateAnnouncement);

            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAnnouncement (string Id)
        {
            var command = new DeleteAnnouncementInfoRequest(Id);

            var result = await _mediator.Send(command);

            return result ? NoContent(): BadRequest(ModelState);
        }
    }
}
