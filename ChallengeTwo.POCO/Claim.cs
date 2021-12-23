using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.POCO
{
    public class Claim
    {
        public Claim(int claimID, ClaimType claimType, string discription, decimal claimAmount, DateTime dateOfIncident, DateTime dateofClaim, bool isValid)
        {
            ClaimID = claimID;
            this.claimType = claimType;
            Discription = discription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateofClaim = dateofClaim;
            IsValid = isValid;
        }

        public Claim()
        {

        }

        public enum ClaimType { Car = 1, Home, Theft }
        public int ClaimID { get; set; }
        public ClaimType claimType { get; set; }
        public string Discription { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateofClaim { get; set; }
        public bool IsValid { get; set; }

    }
}
