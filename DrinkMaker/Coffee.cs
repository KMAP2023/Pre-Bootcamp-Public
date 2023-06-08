public class Coffee : Drink
{

public string RoastType;


// inhertiance
public Coffee(string roastType) : base("Nitro Cold Brew", "dark brown", 66.4, false, 50)
{
    RoastType = roastType;
}

    public override void ShowInfo() //override
    {
        base.ShowInfo();
        Console.WriteLine($"Roast type :{RoastType}");
    }


}