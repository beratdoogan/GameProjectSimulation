using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Manager
{
    public class UserValidationManager : Gamer,IUserValudationService
    {
        public bool Validation(Gamer gamer)
        {
            if(gamer.BirthOfYear == new DateTime(1990,2,3) && gamer.FirstName == "Berat" && gamer.LastName == "Doğan")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Authentication could not be completed");
            } 
        }
    }
}
