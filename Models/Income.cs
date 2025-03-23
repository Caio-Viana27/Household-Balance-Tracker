namespace Household_Balance_Tracker.Models;

using Household_Balance_Tracker.Interfaces;

public class Income : ITransaction
{
    private TransactionType type = TransactionType.INCOME;
    public Income(int id, int personId, string details, double value) : base(id, personId, details, value)
    {

    }

    public override double getValue()
    {
        return value;
    }
}