
using ObjectsAndClasses;

//Main Method

//Console.WriteLine("Hello, World!");
//int num = 15;
//num++;
//Console.WriteLine(num);

Food garfield = new Food();
Console.WriteLine(garfield.Name);


Console.WriteLine("what are you eating today?");
string input = Console.ReadLine();
Food Davis = new Food(input, "salty", "soft", true, 7, 2, 200, new List<string> {"rice", "seaweed", "fish"});
Console.WriteLine(Davis.Portions);
Davis.Eat(2);
Console.WriteLine(Davis.Portions);

Console.WriteLine(Food.DisplayMessage());
Console.WriteLine(Davis.IsFoodTasty());