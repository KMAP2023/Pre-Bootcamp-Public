public class Wine : Drink
{

    public string WineTier;

    public Wine(string wineTier, string diet) : base("Cabernet", "red", 72.5, false, 5)
    {
        WineTier = wineTier;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Level of Wine: {WineTier}");
    }

}
