using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.POCO
{
    public class Menu
    {
        public Menu(int mealNumber, string mealName, string description, decimal price, List<string> listOfIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            ListOfIngredients = listOfIngredients;
        }

        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> ListOfIngredients { get; set; }
    }
}
