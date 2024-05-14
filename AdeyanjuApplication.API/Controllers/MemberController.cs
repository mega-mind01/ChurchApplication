using AdeyanjuApplication.API.Controllers;
using AdeyanjuApplication.DataService.Repository.Interface;
using AdeyanjuApplication.Entities.DTO.Request;
using AutoMapper;
using ChurchApplication.API.Commands.MemberCommands;
using ChurchApplication.API.Queries.MemberQueries;
using ChurchApplication.Entities.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChurchApplication.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MemberController : BaseController
    {
        public MemberController(IUnitOfWork unitOfWork, IMapper mapper, IMediator mediator) : base(unitOfWork, mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllMemberQuery();

            var result = await _mediator.Send(query);

            if (result ==  null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById (string Id)
        {
            var query = new GetMemberByIdQuery(Id);

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddMember([FromBody] CreateUser createUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var command = new CreateMemberInfoRequest(createUser);
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction(nameof(GetById), new { MemberId = result.Id }, result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateMember([FromBody] UpdateUser updateUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = new UpdateMemberInfoRequest(updateUser);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletMember (string Id)
        {
            var command = new DeleteMemberInfoRequest(Id);
            var result = await _mediator.Send(command);

            return result ? NoContent() : BadRequest(ModelState);
        }
    }
}
