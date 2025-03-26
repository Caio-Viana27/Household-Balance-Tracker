namespace Household_Balance_Tracker.Models;

using Household_Balance_Tracker.Interfaces;

public class Income : ITransaction
{
    private TransactionType type = TransactionType.INCOME;
    public Income(int id, string description, double value, string ownerEmailOrId) : base(id, ownerEmailOrId, description, value)
    {

    }

    public override TransactionType getType()
    {
        return type;
    }
}