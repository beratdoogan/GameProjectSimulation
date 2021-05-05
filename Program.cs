using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Manager;


namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Add a new user
            GamerManager gamer = new GamerManager();
            gamer.Add(new Gamer(){Id=1232123,FirstName="Berat",LastName="Doğan",BirthOfYear=new DateTime(1990,2,3),City="Mersin"});

            GamerManager gamer2 = new GamerManager();
            gamer2.Add(new Gamer(){Id=1232123,FirstName="Gizem",LastName="Çakır",BirthOfYear=new DateTime(1995,6,2),City="Ankara"});

            // Add a new game 
            ProductManager product1 = new ProductManager() { Id=129221,ProductName="Half Life 2",ProductCategory="Action",ProductPrice=18,ProductReleaseDate=new DateTime(1990,02,20)};

            // Buy a new Game(Product)
            ProductManager productManager = new ProductManager();
            productManager.Buy(gamer,product1);

            // Validation testing
            UserValidationManager userValidation = new UserValidationManager();
            userValidation.Validation(gamer); // + validation
            userValidation.Validation(gamer2); // - validation (except)
            
            Console.ReadLine();
            
        }
    }
}
