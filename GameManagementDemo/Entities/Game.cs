using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
