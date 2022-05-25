using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    // this class will represent all food items in our program
    internal class Food
    {
        // accessModifier propertyType propertyName
        // RETURN -when something is being handed to us to use, we say that it is being returned to us
        //a funstion returns a string

        public string Name;
        public string Flavor;
        public string Texture;
        public bool IsTasty;
        public int Portions;
        public float Cost;
        public int Calories;
        public List<string> Ingredients;

        // accessModifier optionalModifiers returnType methodName(inputType inputName) {
        //       code we'd like to run
        // }

        //         - void (indicates to us that the method DOES NOT RETURN ANDYTHING!)

        public Food()
        {

            Name = "Lasagna";
            Flavor = "Sour";
            Texture = "hard";
            IsTasty = true;
            Cost = 5;
            Calories = 500;
            Ingredients = new List<string>() { "pasta", "tomato sauce", "Lemon" };
        }

        public Food(string name, string flavor, string texture, bool isTasty, float cost, int portions, int calories, List<string> ingredients)
        {
            Name = name;
            Flavor = flavor;
            Texture = texture;
            IsTasty = isTasty;
            Cost = cost;
            Portions = portions;
            Calories = calories;
            Ingredients = ingredients;
        }

        public void Eat()
        {
            Portions--;
        }

        public void Eat(int numToEat)
        {
            Portions -= numToEat;
        }

        public static string DisplayMessage()
        {
            return "I love food!";
        }

        public bool IsFoodTasty()
        {
            return IsTasty;
        }

    }
}
