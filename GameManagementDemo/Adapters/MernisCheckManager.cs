using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;
using MernisServiceReference;

namespace GameManagementDemo.Concrete
{
    public class MernisCheckManager : IMernisCheckService
    {
        public bool CheckIfRealPerson(Players players)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(players.NationalityId, players.FirstName.ToUpper(),
                players.LastName.ToUpper(), players.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
