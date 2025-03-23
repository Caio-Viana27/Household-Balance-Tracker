namespace Household_Balance_Tracker.Controllers;

using System;
using System.Collections.Generic;
using Household_Balance_Tracker.Interfaces;

/// <summary>
/// Class responsible for managing transactions between veiws and model
/// </summary>
public class TransactionController
{
    /// <summary>
    /// Maps a person's email to a list of ITransactions (Expense, Income)
    /// </summary>
    private Dictionary<string, List<ITransaction>>? transactions = null;
    private int idCounter = 0;

    public TransactionController()
    {
        transactions = new Dictionary<string, List<ITransaction>>();
        System.Console.WriteLine("TransactionController inicialized!");
    }
}