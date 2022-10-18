using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Concrete
{
    public class PlayersManager : IPlayersService
    {
        IMernisCheckService _mernisCheckService;

        public PlayersManager(IMernisCheckService _mernisCheckService)
        {
            this._mernisCheckService = _mernisCheckService;
        }

        public void Add(Players player)
        {

            //Oyuncuyu DB'ye ekleme kodları
            //MERNİS ENTEGRE
            if (_mernisCheckService.CheckIfRealPerson(player))
            {
                Console.WriteLine("Oyuncu başarıyla kaydedildi -->", player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi, lütfen gerçek bir kişi giriniz.");
            }
            
        }

        public void Delete(Players player)
        {
            //Oyuncuyu DB'den silme kodları...
            Console.WriteLine("{0} isimli oyuncunun kaydı sistemden silindi...", player.FirstName);
        }

        public void Update(Players player, string firstName, string lastName)
        {
            player.FirstName = firstName;
            player.LastName = lastName;
            //Oyuncuyu DB'de düzenleme kodları...
            Console.WriteLine("{0} isimli oyuncunun kaydı güncellendi...", player.FirstName);
        }
    }
}
