namespace Household_Balance_Tracker.Models.ViewModels;

using System.ComponentModel.DataAnnotations;

public class DeletePersonViewModel
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? email { get; set; }

    public DeletePersonViewModel()
    {

    }
    public DeletePersonViewModel(string email)
    {
        this.email = email;
    }
}