using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.POCO
{
    public class Badge
    {
        public Badge(int badgeID, ListOfDoorNames listOfDoorNames, string nameOfBadge)
        {
            BadgeID = badgeID;
            this.listOfDoorNames = listOfDoorNames;
            NameOfBadge = nameOfBadge;
        }

        public enum ListOfDoorNames { A1 = 1, A5, B2, B4}
        public int BadgeID { get; set; }
        public ListOfDoorNames listOfDoorNames { get; set; }
        public string NameOfBadge { get; set; }

    }
}
