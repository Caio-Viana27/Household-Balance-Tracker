namespace Household_Balance_Tracker.Controllers;

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using Household_Balance_Tracker.Interfaces;

/// <summary>
/// Class responsible for managing transactions between veiws and model
/// </summary>
public class TransactionController : Controller
{
    /// <summary>
    /// Maps a person's email to a list of ITransactions (Expense, Income)
    /// </summary>
    private Dictionary<string, List<ITransaction>>? transactions = new Dictionary<string, List<ITransaction>>();
    private int idCounter = 0;

    public IActionResult InsertTransactionForm()
    {
        return View();
    }
}