using System.Text.Json;

namespace ChainOfResponsibility;

public class Order : IRequest
{
    public Order(string itemCode, decimal price, int quantity)
    {
        ItemCode = itemCode;
        Price = price;
        Quantity = quantity;
    }
    
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Created { get; } = DateTime.Now;
    
    public string ItemCode { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; init; }
    
    public bool Paid { get; set; } = false;
    public bool Shipped { get; set; } = false;

    public override string ToString() => 
        JsonSerializer.Serialize(this, new JsonSerializerOptions{ WriteIndented = true });
}