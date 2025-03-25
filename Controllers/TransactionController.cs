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

    [HttpPost]
    public IActionResult InsertTransactionForm(TrasactionViewModel model)
    {
        System.Console.WriteLine("Name: " + model.name);
        System.Console.WriteLine("Age: " + model.age);
        System.Console.WriteLine("email: " + model.email);

        /* if (ModelState.IsValid)
        {
            transactions.Add(model.email, new Person(idCounter++, model.name, model.age, model.email));

            ViewBag.Massage = "Registration Successfull";
            return View("Success", model);
        }
        else
        {
            return View("InsertPersonForm");
        } */
    }
}