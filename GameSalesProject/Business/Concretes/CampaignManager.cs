using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Abstracts;
using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Concretes
{
    public class CampaignManager : CampaignService
    {

        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            if(campaigns.Contains(campaign) == true)
            {
                Console.WriteLine(campaign.CampaignName + " Sistemde böyle bir kampanya var ");
            }
            else
            {
                Console.WriteLine(campaign.CampaignName + " Kampanyası sisteme kaydedildi");
                campaigns.Add(campaign);
            }
            
        }

        public void Delete(Campaign campaign)
        {
            if (campaigns.Contains(campaign) == true)
            {
                campaigns.Remove(campaign);
                Console.WriteLine(campaign.CampaignName + " Kampanyası Sistemden silindi");
            }
            else{
                Console.WriteLine("Sistemde böyle bir kampanya bulunmadı");
            }
        }

        public void Update(Campaign campaign)
        {
            if (campaigns.Contains(campaign) == true)
            {
                Console.WriteLine(campaign.CampaignName + " Kampanyasının bilgileri güncellendi");
            }
            else
            {
                Console.WriteLine("Sistemde böyle bir kampanya bulunmamakta");
            }
        }

        

    }
}
