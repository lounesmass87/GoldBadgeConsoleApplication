using ChallengeTwo.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
    public class ClaimRepo
    {
        private readonly List<Claim> _claims = new List<Claim>();

        //C
        public bool CreatClaim(Claim claim)
        {
            int claimcount = _claims.Count();
            int claimID = GenerateUniqueClaimID();
            claim.ClaimID = claimID;
            _claims.Add(claim);
            if(claimcount != claimID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //R
        public List<Claim> GetClaim(int claimID)
        {

            return _claims;
        }
        public Claim GetClaimByclaimID(int claimID)
        {
            foreach (Claim claim in _claims)
            {
                if(claimID == claim.ClaimID)
                {
                    return claim;
                }
            }
            return null;
        }

        //U
        public bool UpdateClaim(Claim newclaim)
        {
            _claims[newclaim.ClaimID] = newclaim;
            if (_claims[newclaim.ClaimID] != newclaim)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //D
        public bool DeletClaim(int claimID)
        {
            Claim ClaimToBeYeeted = GetClaimByclaimID(claimID);
            if(ClaimToBeYeeted == null)
            {
                return false;
            }
            else
            {
                _claims.Remove(ClaimToBeYeeted);
                return true;
            }
        }
        private int GenerateUniqueClaimID()
        {
            int claimCount = _claims.Count();
            return claimCount + 1;
        }

        public List<Claim> GetClaim()
        {
            throw new NotImplementedException();
        }
    }
}
