#pragma warning disable CS8618 
// with this at the top of the file, the warning messages will go away
// This is what you will be using throughout the course everytime you make a model

using System.ComponentModel.DataAnnotations;
// this helps us build custom error messages

namespace DojoSurvey.Models;
// this will give our project the permission it needs to work with these attributes
public class User
{
    // [Required]
    [Required(ErrorMessage = "Name is required!")]
    [MinLength(2, ErrorMessage = "Message must be at least 2 characters in length.")]

    public string Name { get; set; }
    // public string? DojoLocation {get; set;} // ===> by adding a ? at the end of any data type ex. string?
    // intend to be null
    // making if filling out the form, it is optional 

    [Required]
    public string DojoLocation { get; set; }

    [Required]
    public string FavoriteLanguage { get; set; }

    [Required]
    [MinLength(20, ErrorMessage = "Message must be at least 20 characters in length.")]

    public string Comments { get; set; }
}