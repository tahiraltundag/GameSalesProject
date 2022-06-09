using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Concretes
{
    public class MemberCheckManager : MemberCheckService
    {

        public bool CheckIfRealPerson(Member member)
        {
            return true;
        }
    }
}
