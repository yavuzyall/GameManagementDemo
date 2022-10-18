using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine("{0} isimli oyun sisteme eklendi.",game.GameName);
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("{0} isimli oyun sistemden silindi.", game.GameName);
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("{0} isimli oyun başarıyla güncellendi.", game.GameName);
        }
    }
}
