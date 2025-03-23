namespace Household_Balance_Tracker.Models;

using Household_Balance_Tracker.Interfaces;

public class Expense : ITransaction
{
    private TransactionType type = TransactionType.EXPENSE;
    public Expense(int id, int personId, string details, double value) : base(id, personId, details, value)
    {

    }

    public override double getValue()
    {
        return -value;
    }
}