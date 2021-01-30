using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer Added.");
            }
          
            else
	{
                Console.WriteLine("The user has not been verified.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated.");
        }
    }
}
