using ChallengeTwo.POCO;
using ChallengeTwo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.UI
{
    class ProgramUI
    {
        private readonly ClaimRepo _claimRepo = new ClaimRepo();
        public void Run()
        {
            seedata();
            Menu();
        }
        public void Menu()
        {
            Console.WriteLine("Welcome to Komodo Claims Departement\n" +
                "1.See all claims\n" +
                "2.Take care of Next Claim\n" +
                "3.Enter a new claim");
        }
        public void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Seeallclaim();
                        break;
                    case "2":
                        TakecareOfnextclaim();
                        break;
                    case "3":
                        Enteranewclaim();
                        break;
                    default:
                        break;
                }

            }
        }

        private void Enteranewclaim()
        {
            Console.WriteLine("Enter the claim id: 4 ");
            int userInputClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the claime Type: Car");
            string userInputClaimType = Console.ReadLine();
            Console.WriteLine("Enter a claim description: Wreck on I-70");
            string userInputDiscription = Console.ReadLine();
            Console.WriteLine("Amount of Damage: $2000.00");
            decimal userInputPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Date Of Accident: 4/28/18");
            DateTime userInputDateofAccident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date of Claim:4/28/18");
            DateTime userInputDateofclaim = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("This claim is valid");
            bool userInputIsvalid = bool.Parse(Console.ReadLine());


        }

        private void TakecareOfnextclaim()
        {
            throw new NotImplementedException();
        }

        private void Seeallclaim()
        {
            Console.Clear();
            List<Claim> ListOFAllClaims = _claimRepo.GetClaim();
            foreach (var claim in ListOFAllClaims)
            {
                DisplayClaims(claim);
            }
            Console.ReadKey();

        }
        private static void seedata()
        {   
        }
        private void DisplayClaims(Claim claim)
        {
            Console.WriteLine($"{claim.ClaimID}" + $"{claim.claimType}" + $"{claim.Discription}" + $"{claim.ClaimAmount}" + $"{claim.DateOfIncident}" + $"{claim.DateofClaim}" + $"{claim.IsValid}");
            Console.ReadLine();
        }

    }
}
