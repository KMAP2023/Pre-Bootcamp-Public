// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    Soda MySoda = new Soda("Diet Soda", "Cola");
    Console.WriteLine(MySoda.Name);
    MySoda.ShowInfo();

    Wine LoveWine = new Wine("Dry", "healthy diet");
    Console.WriteLine(LoveWine.Name);
    LoveWine.ShowInfo();

    Coffee YumCoffee = new Coffee("Dark Roast"); // inheritance
    Console.WriteLine(YumCoffee.Name);
    YumCoffee.ShowInfo();



// polymorphism
List<Drink> AllDrinks = new List<Drink>();
AllDrinks.Add(MySoda);
AllDrinks.Add(LoveWine);
AllDrinks.Add(YumCoffee);

foreach(Drink a in AllDrinks)
{
    if(a is Coffee)
    {
        Console.WriteLine("This aroma from this coffee is delicious!");
    }
}

foreach(Drink a in AllDrinks)
{
    if(a is Wine)
    {
        Console.WriteLine("This pairs perfect with my food!");
    }
}

foreach(Drink a in AllDrinks)
{
    if(a is Soda)
    {
        Console.WriteLine("Nothing like an ice cold soda to satisfy a full belly!");
    }
}