namespace Household_Balance_Tracker.Models;

using Household_Balance_Tracker.Interfaces;

public class Income : ITransaction
{
    private TransactionType type = TransactionType.INCOME;
    public Income(int id, string details, double value, string ownerEmailOrId) : base(id, ownerEmailOrId, details, value)
    {

    }

    public override double getValue()
    {
        return value;
    }
}