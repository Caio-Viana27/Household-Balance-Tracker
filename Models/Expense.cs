namespace Household_Balance_Tracker.Models;

using Household_Balance_Tracker.Interfaces;

public class Expense : ITransaction
{
    private TransactionType type = TransactionType.EXPENSE;
    public Expense(int id, string description, double value, string ownerEmailOrId) : base(id, ownerEmailOrId, description, value)
    {

    }

    public override TransactionType getType()
    {
        return type;
    }
}