using ChallengeOne.POCO;
using ChallengeOne.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.UI
{
    class ProgramUI
    {
        private readonly MenuRepo _MenuRepo = new MenuRepo();
        public void Run()
        {
            RunApplication();
        }
        public void Menu()
        {
            Console.WriteLine("Welcome to t Komodo Cafe\n" +
                "1.View all Items\n" +
                "2.Add Items\n" +
                "3.Delete Itmes");
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ViewAllItems();
                        break;
                    case "2":
                        AddItems();
                        break;
                    case "3":
                        DeleteItems();
                        break;
                    default:
                        Console.WriteLine("Invalid input, please enter number1-3");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void DeleteItems()
        {
            Console.WriteLine("Entre the meal number you like to remove");
            int userInputMealNumber = int.Parse(Console.ReadLine());
        }

        private void AddItems()
        {
            Console.WriteLine("please input the meal number");
            int userInputMealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please input the meal name");
            string userInputMealName = Console.ReadLine();
            Console.WriteLine("please input the price");
            decimal userInputPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("please input the list of ingredients");
            string userInputListOfIngredients = Console.ReadLine();
            
        }

        private void ViewAllItems()
        {
            Console.Clear();
            List<Menu> listOfItems = _MenuRepo.GetMenu();
            foreach (var menu in listOfItems)
            {
                DisplayMenuInfo(menu);
            }
            Console.ReadKey();
        }
        private void DisplayMenuInfo(Menu menu)
        {
            Console.WriteLine($"{menu.MealNumber}\n" +
                $"{menu.MealName}\n" +
                $"{menu.Price}\n" +
                $"{menu.ListOfIngredients}\n");
            Console.WriteLine("**************");
        }
    }
}
