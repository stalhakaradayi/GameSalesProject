using System;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationService());
            gamerManager.Add(new Gamer {BirthYear = 1995, FirstName = "Şükrü Talha",LastName = "Karadayı",NationalityId = 12345 });



            Console.ReadLine();

        }
    }
}
