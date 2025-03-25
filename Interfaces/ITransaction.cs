namespace Household_Balance_Tracker.Interfaces;

/// <summary>
/// Abstract class that creates the contract for Transactions
/// </summary>
public abstract class ITransaction
{
    protected int id;
    protected string ownerEmailOrId { get; }
    protected string? details { get; }
    protected double value { get; }

    protected ITransaction(int id, string emailOrId, string details, double value)
    {
        this.id = id;
        this.ownerEmailOrId = emailOrId;
        this.details = details;
        this.value = value;
    }
    public abstract double getValue();
    public abstract TransactionType getType();
}

public enum TransactionType { EXPENSE, INCOME }