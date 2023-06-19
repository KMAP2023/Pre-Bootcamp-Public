// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian I", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// Use LINQ to find the first eruption that is in Chile and print the result
Eruption eruption = eruptions.First(eruption => eruption.Location == "Chile");
Eruption.PrintEach(eruptions); // this is to print out all the volcanos that erupted in chile
Console.WriteLine(eruption.ToString()); // this is to find the first eruption in chile

Eruption eruptionHW = eruptions.FirstOrDefault(eruptionHW => eruptionHW.Location == "Hawaiian Is");
if(eruptionHW != null)
{
    Console.WriteLine(eruptionHW.ToString());
}
else
{
    Console.Write("No Hawaiian Is eruptions is found....");
}

// GreenLand
Eruption eruptionGL = eruptions.FirstOrDefault(eruptionGL => eruptionGL.Location == "GreenLand");
if(eruptionGL != null)
{
    Console.WriteLine(eruptionGL.ToString());
}
else
{
    Console.WriteLine("There are no eruptions found in GreenLand.");
}



// elevation more than the 2000m
IEnumerable<Eruption> elevationTwoPlus = eruptions.Where(numEle => numEle.ElevationInMeters > 2000).ToList();
Eruption.PrintEach(elevationTwoPlus);

// find all eruptions where the volcano's name starts with "L" and print them
// also print the numbers of the eruptions
// //we need for loops/foreach to unbox so it can rummage through the box and print out what we want it to print out
List<Eruption> volcanoStartsWithL = eruptions.Where( lName => lName.Volcano.StartsWith("L")).ToList();
foreach(var item in volcanoStartsWithL)
{
    Console.WriteLine(item.ToString() + "numbers of eruptions is " + eruptions.Count());
}

 // Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int peakAndNum = eruptions.Max(peak => peak.ElevationInMeters);
Console.WriteLine($"the mountain with the highest elevation is {peakAndNum}");



//  // print alphabetically 
// // goes through the list, and sort alphabetically and prints a new list but IS alphabetized
List<string> alpha = eruptions.OrderBy(sVolc => sVolc.Volcano).Select(a => a.Volcano).ToList();
Console.WriteLine(string.Join(", ", alpha));


// // print the sum elevations of all the volcanos
// // grabbing the intergers of all the elevation and summing it together
int sumOfEl = eruptions.Sum(total => total.ElevationInMeters);
Console.WriteLine($"this is the sum of all the eruptions {sumOfEl}");

// **// print all volcanos after the year 2000
// // this brings the true or false
string plusYearTwo = eruptions.Any(p => p.Year > 2000).ToString();
Console.WriteLine(plusYearTwo);

// // *** working just yet// print all volcanos after the year 2000
// // // this prints out all the volcanos after the year 2000
// List<Eruption> plusYearTwo = eruptions.Where(p => p.Year > 2000).ToList();
// Eruption.PrintEach(plusYearTwo);
// // foreach(var item in plusYearTwo)
// // {
// //     Console.WriteLine(string.Join(" ,", plusYearTwo));
// // }

// //find all the stratovolcanoes and print just the first three
IEnumerable<Eruption> firstStratV = eruptions.Where(strat => strat.Type == "Stratovolcano").Take(3);
PrintEach(firstStratV, "first 3 stratavolcanos");

// //Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
List<Eruption> oneLessEra = eruptions.Where(lessOne => lessOne.Year < 1000).OrderBy(vName => vName.Volcano).ToList();
PrintEach(oneLessEra.ToList());

// //Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
List<string> oneName = eruptions.Where(lessOne => lessOne.Year < 1000).OrderBy(vName => vName.Volcano).Select(nv => nv.Volcano).ToList();
Console.WriteLine(string.Join(", ", oneName));

static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}