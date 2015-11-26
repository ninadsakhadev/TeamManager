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
        IUnitOfWork unitOfWork;
        IRepository<Member> repository;

        public MemberService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.repository = unitOfWork.Repository<Member>();
        }

        public void AddMember(Member member)
        {
            repository.Add(member);
        }

        public IQueryable<Member> GetAllMembers()
        {
            return repository.GetAllWithIncludes("Members");
        }

        public IQueryable<Member> GetAllMembersByTeam(int id)
        {
            return repository.FindByWithIncludes(t => t.Teams.Any(m => m.Id == id), t => t.Skills, t => t.Certifications);
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
