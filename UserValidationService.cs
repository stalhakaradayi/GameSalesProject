using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class UserValidationService : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Şükrü Talha" && gamer.LastName == "Karadayı"&& gamer.NationalityId == 12345)
            {
               
                return true;
            }
            else
            {
                return false;
                
            }
        }
    }
}
