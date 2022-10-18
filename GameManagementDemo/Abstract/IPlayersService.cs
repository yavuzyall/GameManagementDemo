using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementDemo.Abstract
{
    public interface IPlayersService
    {
        void Add(Players player);
        void Delete(Players player);
        void Update(Players player, string firstName, string lastName);

    }
}
