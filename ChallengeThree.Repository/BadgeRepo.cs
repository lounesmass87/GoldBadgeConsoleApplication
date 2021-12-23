using ChallengeThree.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.Repository
{
    public class BadgeRepo
    {
        private Dictionary<int, Badge> _ListOfDoorNames = new Dictionary<int, Badge>();

        //C
        public bool CreatBadge(Badge badge)
        {
            int badgecount = _ListOfDoorNames.Count();
            int badgeID = GenerateUniqueBadgeID();
            badge.BadgeID = badgeID;
            _ListOfDoorNames.Add(badge.BadgeID, badge);


            if (!_ListOfDoorNames.ContainsKey(badge.BadgeID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //R
        public Badge GetBadgeBYId(int id)
        {
            return _ListOfDoorNames[id];
        }
        public Dictionary<int, Badge> GetAllBAdges()
        {
            return _ListOfDoorNames;
        }
        //U
        public static bool UpdateDoorName(Badge newDoor)
        {
            Badge OldDoor = _ListOfDoorNames[newDoor.BadgeID];
            OldDoor.BadgeID = newDoor.BadgeID;
            OldDoor.NameOfBadge = newDoor.NameOfBadge;
            OldDoor.listOfDoorNames = newDoor.listOfDoorNames;
            if (_ListOfDoorNames[newDoor.BadgeID] != newDoor)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        


        //D
        private int GenerateUniqueBadgeID()
        {
        int badgeCount = _ListOfDoorNames.Count();
            return badgeCount + 1;
        }
    }
}
