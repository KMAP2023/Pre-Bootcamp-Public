public class Soda : Drink
{

    public string VersionDiet;

    public Soda(string versionDiet, string manufacturedBy) : base("Mountain Dew Glacier", "blue", 65.5, true, 70)
    {
        VersionDiet = versionDiet;
    }
    public override void ShowInfo()
    {
// this area was commented out because it's considered to be redundant and not dry but also repetative
        //Console.WriteLine($"Name: {Name}");
        // Console.WriteLine($"Color: {Color}");
        // Console.WriteLine($"Temp: {Temperature}");
        // Console.WriteLine($"Carbonated: {IsCarbonated}");
        base.ShowInfo();
        Console.WriteLine($"Diet Version: {VersionDiet}");
    }
}