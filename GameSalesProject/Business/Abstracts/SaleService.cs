using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Abstracts
{
    public interface SaleService
    {
        void Sale(Game game, Campaign campaign, Member member);
        
    }
}
