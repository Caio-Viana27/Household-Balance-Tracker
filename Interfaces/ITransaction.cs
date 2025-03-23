namespace Household_Balance_Tracker.Interfaces;

/// <summary>
/// Abstract class that creates the contract for Transactions
/// </summary>
public abstract class ITransaction
{
    protected int id;
    protected int personId { get; }
    protected string? details { get; }
    protected double value { get; }

    protected ITransaction(int id, int personId, string details, double value)
    {
        this.id = id;
        this.personId = personId;
        this.details = details;
        this.value = value;
    }
    public abstract double getValue();
}

public enum TransactionType { EXPENSE, INCOME }