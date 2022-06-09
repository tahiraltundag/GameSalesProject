using GameSalesProject.Adapters;
using GameSalesProject.Business.Abstracts;
using GameSalesProject.Business.Concretes;
using GameSalesProject.Entities.Concretes;
using System;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member(1,"Mehmet Tahir","Altundağ", 12345678901, new DateTime(1999,04,10), "12345");
            Member member2 = new Member(1, "Mehmet Tahir", "Altundağ", 12345678901, new DateTime(1998,04,10), "12345");

            MemberManager memberManager = new MemberManager(new MernisCheckManager());
            memberManager.Add(member1);

            Console.WriteLine();

            Game game1 = new Game(1, "Valorant", "18 Gb Hd", 134);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine();

            Campaign campaign1 = new Campaign(1, "Efsane Cuma", 0.18);
            Campaign campaign2 = new Campaign(1, "Efsane Cuma", 0.18);


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);

            Console.WriteLine();

            

            Console.WriteLine();

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1, campaign1, member1);

            Console.WriteLine();

            MernisCheckManager mernisChekManager = new MernisCheckManager();
            mernisChekManager.CheckIfRealPerson(member1);

            Console.ReadLine();
        }
    }
}
