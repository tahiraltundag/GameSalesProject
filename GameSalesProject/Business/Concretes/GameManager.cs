using GameSalesProject.Business.Abstracts;
using GameSalesProject.Entities.Abstracts;
using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Concretes
{
    public class GameManager : GameService
    {

        List<Game> games = new List<Game>();

        public void Add(Game game)
        {
            if (games.Contains(game) == true)
            {
                Console.WriteLine(game.GameName + " Sistemde Böyle bir ürün var");
            }
            else
            {
                games.Add(game);
                Console.WriteLine(game.GameName + " Ürünü sisteme kaydedildi");
            }
        }

        public void Delete(Game game)
        {
            if (games.Contains(game) == true)
            {
                games.Remove(game);
                Console.WriteLine(game.GameName + " ürünü sistemden silindi");
            }
            else
            {
                Console.WriteLine("Böyle bir ürün bulunmamakta");
            }
        }

        public void Update(Game game)
        {
            if(games.Contains(game) == true)
            {
                Console.WriteLine("Ürün bilgileri güncellendi");
            }
            else
            {
                Console.WriteLine("Böyle bir ürün bulunmamaktadır");
            }
        }
    }
}
