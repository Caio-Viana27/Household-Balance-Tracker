namespace Household_Balance_Tracker.Models.ViewModels;

using System.ComponentModel.DataAnnotations;

public class TransactionViewModel
{
    [Required]
    public string? emailOrId { get; set; }
    [Required]
    public string? details { get; set; }
    [Required]
    public string? type { get; set; }
    [Required]
    public double value { get; set; }
}