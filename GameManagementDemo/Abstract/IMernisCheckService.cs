using System;
using System.Collections.Generic;
using System.Text;
using GameManagementDemo.Entities;
using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;

namespace GameManagementDemo.Abstract
{
    public interface IMernisCheckService
    {
        bool CheckIfRealPerson(Players players);
    }
}
