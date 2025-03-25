namespace Household_Balance_Tracker.Controllers;

using System;
using System.Collections.Generic;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using Household_Balance_Tracker.Models;
using Household_Balance_Tracker.Models.ViewModels;

/// <summary>
/// Class responsible for managing person data between veiws and model
/// </summary>
public class PersonController : Controller
{
    public static Dictionary<string, Person>? people = new Dictionary<string, Person>();
    public static int idCounter = 0;

    public IActionResult InsertPersonForm()
    {
        return View();
    }

    public IActionResult RemovePersonForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult InsertPerson(PersonViewModel model)
    {
        System.Console.WriteLine("Name: " + model.name);
        System.Console.WriteLine("Age: " + model.age);
        System.Console.WriteLine("email: " + model.email);

        if (ModelState.IsValid)
        {
            people.Add(model.email, new Person(idCounter++, model.name, model.age, model.email));

            ViewBag.Massage = "Registration Successfull";
            return View("SuccessfulPersonWarning", model);
        }
        else
        {
            return View("InsertPersonForm");
        }
    }

    [HttpPost]
    public IActionResult RemovePerson(PersonViewModel model)
    {
        if (model.email == null)
        {
            System.Console.WriteLine("Email is null!");
            return View("RemovePersonForm");
        }

        if (people.Count == 0 || !people.ContainsKey(model.email))
        {
            return View("RemovePersonForm");
        }

        Person toBeRemoved = null;
        people.TryGetValue(model.email, out toBeRemoved);

        // implemt remove Transactions beloging to person.email

        people.Remove(model.email);
        return View("SuccessfulPersonWarning", new PersonViewModel(toBeRemoved.getName(),
                                                   toBeRemoved.getAge(),
                                                   toBeRemoved.getEmail()));
    }
}