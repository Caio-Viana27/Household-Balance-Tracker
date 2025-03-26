namespace Household_Balance_Tracker.Interfaces;

/// <summary>
/// Abstract class that creates the contract for Transactions
/// </summary>
public abstract class ITransaction
{
    protected int id;
    protected string ownerEmailOrId { get; }
    protected string? description { get; }
    protected double value { get; }

    protected ITransaction(int id, string emailOrId, string description, double value)
    {
        this.id = id;
        this.ownerEmailOrId = emailOrId;
        this.description = description;
        this.value = value;
    }
    public double getValue()
    {
        return value;
    }

    public int getId()
    {
        return id;
    }

    public string getDescription()
    {
        return description;
    }

    public string getOwnerIdentifier()
    {
        return ownerEmailOrId;
    }
    public abstract TransactionType getType();
}

public enum TransactionType { EXPENSE, INCOME }