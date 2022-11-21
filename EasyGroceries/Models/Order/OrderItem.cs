namespace EasyGroceries.Models;
public class OrderItem {
    public Guid Id {get;}
    public Catalog Item{get;}
    public int Quantity {get;}
    public OrderItem(Guid id, Catalog item, int quantity)
    {
        Id = id;
        Item = item;
        Quantity = quantity;
    }
}