namespace Household_Balance_Tracker.Models.ViewModels;

using System.ComponentModel.DataAnnotations;

public class PersonViewModel
{
    [Required(ErrorMessage = "Name is required")]
    public string? name { get; set; }

    [Required(ErrorMessage = "Age is required")]
    [Range(0, 120, ErrorMessage = "Age must be between 0 and 120")]
    public int age { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? email { get; set; }

    public PersonViewModel()
    {

    }
    public PersonViewModel(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }
}