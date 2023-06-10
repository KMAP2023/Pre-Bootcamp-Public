// This brings all the MVC features we need to this file
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // must import****
using DojoSurvey.Models;



namespace DojoSurvey.Controllers;


public class HomeController : Controller //recommend naming your files as the class that is being defined from within
{
    // [HttpGet] // We will go over this in more detail on the next page    
    // [Route("")] // We will go over this in more detail on the next page
    [HttpGet("")] // this combines both line 6 and 7
    [HttpGet("/index")] //we can stack routes by adding multiple http get attributes
    public ViewResult Index()
    {
        ViewBag.Name = "Malo";
        return View("Index"); //
        // view function by default is going to look at the name of the method that it
        //called it and looks for a page that matches public ViewResult Index
        // recommend of getting into the habit of specifying the name of the file
        // bc later on it is helpful for the validations
        // // create a views folder
    }
    // public string Index() => "Hello World! I love Coffee! 1st route!"; // ====> function with fat arrow


    // [HttpGet("/results")]
    // public ViewResult Results()
    // {
    //     ViewBag.Example = "Hello World!";
    //     return View("Results");
    //     /*
    //     Each controller method / 'action' has it's own ViewBag that is SEPERATE,
    //     the data is not shared between them

    //     The ViewBag properties are automatically available in the View that is returned from this method.

    //     @ symbol is essentially signifies c sharp code starts here
    //     like adding
    //     - variables into diff elem
    //     - run foreach loop
    //     - create variables
    //     - pull data and display it
    //     */
    // }

    [HttpPost("addUser")]
    public IActionResult AddUser(User user)
    {
        if(ModelState.IsValid)
        {
        // //     // Do something with form input
        ViewBag.Name = user.Name;
        ViewBag.DojoLocation = user.DojoLocation;
        ViewBag.FavoriteLanguage = user.FavoriteLanguage;
        ViewBag.comment = user.Comments;
        // Console.WriteLine($"{Name} goes to {DojoLocation}, and their favorite language is {FavoriteLanguage}, and {Name} also left us with a review! Commenting {Comment}");
        return View("Results", user);
        }
        return  View("Index");
    }
    // viewbag here shows the submission on the results page
    // Then don't forget to return some kind of result!
    // viewbag can only rather be seen by the developers to see pre errors that users might encounter
    // ViewModels => create a Models folder and intergrate the same main items needed
    // so we need to make a namespace ==> must be made with the same name as the project itself
    // take for example in the Models folder we created User.cs
    // inside that folder, the namespace will be 

}
// public IActionResult Process(string TextField, int NumberField)
// {    
//     Console.WriteLine($"My text was: {TextField}");
//     Console.WriteLine($"My number was: {NumberField}");
// }