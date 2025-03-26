namespace Household_Balance_Tracker.Models.ViewModels;

using System.ComponentModel.DataAnnotations;

public class TransactionViewModel
{
    [Required(ErrorMessage = "Owner identifier is required")]
    public string? emailOrId { get; set; }
    [Required(ErrorMessage = "A description is required")]
    public string? description { get; set; }
    [Required(ErrorMessage = "Type is required")]
    public string? type { get; set; }
    [Required(ErrorMessage = "Value is required")]
    public double value { get; set; }
}