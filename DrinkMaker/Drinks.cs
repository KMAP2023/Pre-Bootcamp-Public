public class Drink
{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;

    // We need a basic constructor that takes all these features in
    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
    }

    public virtual void ShowInfo() // by using the keyword virtual and going to the child class, this is how we override
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Temp: {Temperature}");
        Console.WriteLine($"Carbonated: {IsCarbonated}");
        Console.WriteLine($"Calories: {Calories}");

        Console.WriteLine($"I love to drink {Name}, the color {Color} brings it a nice touch, the drink has {Calories} grams of calories.");
    }





}

