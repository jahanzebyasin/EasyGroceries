namespace EasyGroceries.Models;
public class Catalog {
    public Guid Id{get;}
    public string Name{get;}
    public string Description{get;}
    public int Quantity{get;}
    public decimal Price{get;}
    public string Type {get;}

    public Catalog(Guid id, string name, string description, int quantity, decimal price, string type)
    {
        Id = id;
        Name = name;
        Description = description;
        Quantity = quantity;
        Price = price;
        Type = type;
    }
}