namespace P01_SalesDatabase.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string CreaditCardNumber { get; set; }
    public decimal Sale { get; set; }
}