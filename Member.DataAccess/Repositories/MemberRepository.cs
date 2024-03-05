using Member.Application.Abstractions;
using Member.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.DataAccess.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public static IEnumerable<MemberEntity> lstMembers =
        [
            new MemberEntity { Id = 7, Name = "John Doe", Type = "G", Address = "New York" },
            new MemberEntity { Id = 8, Name = "Jane Doe", Type = "S", Address = "Los Angeles" },
            new MemberEntity { Id = 9, Name = "Alice Smith", Type = "G", Address = "Chicago" },
            new MemberEntity { Id = 10, Name = "Bob Johnson", Type = "S", Address = "Houston" },
            new MemberEntity { Id = 11, Name = "Emily Brown", Type = "S", Address = "Phoenix" },
            new MemberEntity { Id = 12, Name = "Michael Wilson", Type = "G", Address = "Philadelphia" },
            new MemberEntity { Id = 13, Name = "Sophia Martinez", Type = "G", Address = "San Antonio" },
            new MemberEntity { Id = 14, Name = "James Anderson", Type = "S", Address = "San Diego" }
        ];

        public async Task<IEnumerable<MemberEntity>> GetAllMembers()
        {
            return await Task.FromResult(lstMembers);
        }
    }
}
