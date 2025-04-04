public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public void SetProduct(string name, string productId, double price, int quantity=1)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalItemCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }

    public void DisplayItem()
    {
        Console.WriteLine($"    ${Math.Round(TotalItemCost(), 2)}: {_name} ({_productId}) . . . x{_quantity}");
    }

}