using GameSalesProject.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities.Concretes
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }

        public Campaign(int id, string campaignName, double discountRate)
        {
            Id = id;
            CampaignName = campaignName;
            DiscountRate = discountRate;
        }
    }
}
