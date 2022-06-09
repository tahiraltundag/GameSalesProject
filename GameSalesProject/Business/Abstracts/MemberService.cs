using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Abstracts
{
    public interface MemberService
    {
        void Add(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
