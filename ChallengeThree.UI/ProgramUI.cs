using ChallengeThree.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.UI
{
    class ProgramUI
    {
        private static BadgeRepo _BadgeRepo = new BadgeRepo();
        public void Run()
        {
            seedata();
            Menu();
        }

        private void seedata()
        {
            throw new NotImplementedException();
        }

        private static void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin, Whta would you like to to\n" +
                    "1.Add a badge\n" +
                    "2.Edit a badge\n" +
                    "3. list all Badges");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Addabadge();
                        break;
                    case "2":
                        Editabadge();
                        break;
                    case "3":
                        Listallbadges();
                        break;
                    default:
                        break;

                }
            }
        }

        private static void Listallbadges()
        {
            throw new NotImplementedException();
        }

        private static void Editabadge()
        {
            throw new NotImplementedException();
        }

        private static void Addabadge()
        {
            Console.WriteLine("What is the number on the badge: 12345");
            Console.WriteLine("List door that it needs access to: A5");
            Console.WriteLine("Any other doors(y/n)?");
            Console.ReadLine();
        }
    }
}
