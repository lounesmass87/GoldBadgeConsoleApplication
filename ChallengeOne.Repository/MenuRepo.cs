using ChallengeOne.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Repository
{
    public class MenuRepo
    {
        private readonly List<Menu> _menu = new List<Menu>();
        private int _count = 0;


        //Creat
        public void CreatMenu(Menu Items)
        {
            _menu.Add(Items);
        }
        //Read
        public List<Menu> GetMenu()
        {
            return _menu;
        }
        //Update

        //Delete
        public void DeleteMenu(int mealNumber)
        {
            _menu.RemoveAt(mealNumber);
        }
    }
}
