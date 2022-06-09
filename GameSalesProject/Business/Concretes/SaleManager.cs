using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Concretes
{
    public class SaleManager : SaleService
    {

        MemberService _memberService;

        public SaleManager()
        {
        }

        public SaleManager(MemberService memberService)
        {
            _memberService = memberService;
        }

        public void Sale(Game game, Campaign campaign, Member member)
        {
            
            Console.WriteLine(game.GameName + " Oyununun Fiyatı : " + game.Price);
            Console.WriteLine(game.GameName +" oyununa %" + campaign.DiscountRate * 100 
            + " indirim uygulandığında oyununun indirimli fiyatı : " + (game.Price-(game.Price * campaign.DiscountRate)) + " TL");
            Console.WriteLine(game.GameName + " oyunu " + (game.Price - (game.Price * campaign.DiscountRate)) + "TL fiyatına "+
                                     member.FirstName +" oyuncusuna satılmıştır.");
            
            
        }
    }
}
