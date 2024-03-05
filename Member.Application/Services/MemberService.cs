using Member.Application.Abstractions;
using Member.Application.Services.Interfaces;
using Member.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository ??
                throw new ArgumentNullException(nameof(memberRepository));
        }

        public async Task<IEnumerable<MemberEntity>> GetAllMembers()
        {
            return await _memberRepository.GetAllMembers();
        }
    }
}
