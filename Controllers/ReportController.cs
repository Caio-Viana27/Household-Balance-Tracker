namespace Household_Balance_Tracker.Controllers;

using System;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using Household_Balance_Tracker.Models;

/// <summary>
/// Class responsible for managing reports between veiws and model
/// </summary>
public class ReportController : Controller
{
    public IActionResult BalanceReport()
    {
        return View();
    }
}