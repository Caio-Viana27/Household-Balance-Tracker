namespace Household_Balance_Tracker.Controllers;

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using Household_Balance_Tracker.Interfaces;
using Household_Balance_Tracker.Models;
using Household_Balance_Tracker.Models.ViewModels;

/// <summary>
/// Class responsible for managing transactions between veiws and model
/// </summary>
public class TransactionController : Controller
{
    /// <summary>
    /// Maps a person's email to a list of ITransactions (Expense, Income)
    /// </summary>
    public static Dictionary<string, List<ITransaction>>? transactions = new Dictionary<string, List<ITransaction>>();
    protected static int idCounter = 0;

    public IActionResult InsertTransactionForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult InsertTransaction(TransactionViewModel model)
    {
        System.Console.WriteLine("Details: " + model.details);
        System.Console.WriteLine("Value: " + model.value);
        System.Console.WriteLine("Type: " + model.type);
        System.Console.WriteLine("Person Id: " + model.emailOrId);

        Person transactionOwner = getOwner(model.emailOrId);

        if (ModelState.IsValid)
        {
            if (transactionOwner == null)
            {
                return View("TransactionFailedPersonNotFound", model);
            }

            if (transactionOwner.getAge() < 18 && "Income".Equals(model.type))
            {
                return View("TransactionFailedPersonIsMinor", model);
            }

            addNewTransaction(transactionOwner.getEmail(), model);

            ViewBag.Massage = "Registration Successfull";
            return View("SuccessfulTransactionWarning", model);
        }
        else
        {
            return View("InsertTransactionForm");
        }
    }

    private void addNewTransaction(string? ownerEmail, TransactionViewModel? model)
    {
        if ("Expense".Equals(model.type))
        {
            addToList(ownerEmail, new Expense(idCounter++, model.details, Convert.ToDouble(model.value), model.emailOrId));
        }
        else if ("Income".Equals(model.type))
        {
            addToList(ownerEmail, new Income(idCounter++, model.details, Convert.ToDouble(model.value), model.emailOrId));
        }
    }

    private void addToList(string key, ITransaction newTransaction)
    {
        if (!transactions.ContainsKey(key))
        {
            var newlist = new List<ITransaction>();
            newlist.Add(newTransaction);

            transactions.Add(key, newlist);
            return;
        }

        transactions.TryGetValue(key, out List<ITransaction> list);
        list.Add(newTransaction);
    }

    /// <summary>
    /// Simple method that return if an id or email exists in a dictionary
    /// </summary>
    /// /// <param name="emailOrId">The email or ID of the person.</param>
    /// <returns>The matching <see cref="Person"/> if found; otherwise, <c>null</c>.</returns>
    private Person getOwner(string? emailOrId)
    {
        if (emailOrId == null)
            return null;

        if (Int32.TryParse(emailOrId, out int id))
        {
            if (id < PersonController.idCounter)
                return null;

            foreach (Person person in PersonController.people.Values)
            {
                if (person.getId() == id)
                    return person;
            }
            return null;
        }

        PersonController.people.TryGetValue(emailOrId, out Person value);
        return value;
    }

    public static bool removePersonTransactions(string? email)
    {
        if (!transactions.ContainsKey(email))
        {
            return false;
        }
        transactions.Remove(email);
        return true;
    }
}