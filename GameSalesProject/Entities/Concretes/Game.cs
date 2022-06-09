using GameSalesProject.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Entities.Concretes
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Details { get; set; }
        public int Price { get; set; }

        public Game(int id, string gameName, string details, int price)
        {
            Id = id;
            GameName = gameName;
            Details = details;
            Price = price;
        }
    }
}
