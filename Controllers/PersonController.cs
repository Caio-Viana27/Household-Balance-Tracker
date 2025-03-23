namespace Household_Balance_Tracker.Controllers;

using System;
using System.Collections.Generic;
using Household_Balance_Tracker.Models;

/// <summary>
/// Class responsible for managing person data between veiws and model
/// </summary>
public class PersonController
{
    private Dictionary<string, Person>? people = null;
    private int idCounter = 0;

    public PersonController()
    {
        people = new Dictionary<string, Person>();
        System.Console.WriteLine("PersonController inicialized!");
    }
}