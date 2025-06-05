namespace Bank;

public class BankCustomer
{
    public BankCustomer()
    {
        Console.WriteLine("Bank Customer created!");
    }

    public BankCustomer(string firstName, string lastName)
    {
        Console.WriteLine($"Bank customer created: {firstName} {lastName}");
    }
}