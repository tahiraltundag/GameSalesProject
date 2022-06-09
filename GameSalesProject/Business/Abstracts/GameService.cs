using GameSalesProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Business.Abstracts
{
    public interface GameService
    {
        void Add(Game product);
        void Delete(Game product);
        void Update(Game product);
    }
}
