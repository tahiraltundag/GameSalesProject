using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Abstracts
{
    public interface MemberCheckService
    {
        bool CheckIfRealPerson(Member member);
    }
}
