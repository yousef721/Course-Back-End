namespace P01_SalesDatabase.Models;

public class Sale
{
    public int SaleId { get; set; }
    public int Product { get; set; }
    public int Customer { get; set; }
    public decimal Store { get; set; }
    public DateTime Date { get; set; }
}