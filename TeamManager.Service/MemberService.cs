using TeamManager.DAL.Common;
using TeamManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Service
{
    public class MemberService : IMemberService
    {
        IRepository<Member> repository;

        public MemberService(IRepository<Member> repository)
        {
            this.repository = repository;
        }

        public void AddMember(Member member)
        {
            repository.Add(member);
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return repository.GetAllWithIncludes("Members");
        }

        //public Member GetById(int id)
        //{
        //    return repository.GetByIdWithIncludes(t => t.Id == id, m=>m.Skills,m=>m.Certifications);
        //}

        public Member GetById(int id)
        {
            return repository.GetByIdWithIncludes(t => t.Id == id, "Skills,Certifications");
        }
    }
}
