using Member.Application.Services.Interfaces;
using Member.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Member.API.Controllers
{
    [Route("api/members")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService ??
                throw new ArgumentNullException(nameof(memberService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberEntity>>> GetAllMembers()
        {
            var memberToReturn = await _memberService.GetAllMembers();
            return Ok(memberToReturn);
        }
    }
}
