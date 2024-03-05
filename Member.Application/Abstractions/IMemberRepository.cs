using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Member.Domain.Models;

namespace Member.Application.Abstractions
{
    public interface IMemberRepository
    {
        Task<IEnumerable<MemberEntity>> GetAllMembers();
    }
}
