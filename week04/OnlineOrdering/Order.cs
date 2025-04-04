using System.Reflection.Metadata;

public class Order
{
 private List<Product> _products;
 private Customer _customer;

 public void SetOrder(string customerName, string address)
 {
    _products = new List<Product>{};
    _customer = new Customer();
    _customer.SetCustomer(customerName, address);
 }

 public void AddProduct(string name, string productId, double price, int quantity)
 {
    Product newProduct = new Product();
    newProduct.SetProduct(name, productId, price, quantity);
    _products.Add(newProduct);
 }

 public double CalcOrderCost()
 {
    double orderCost = 0;
    foreach(Product product in _products)
    {
        orderCost += product.TotalItemCost();
    }
    return orderCost;
 }

 public void ReturnPackingLabel()
 {
    Console.WriteLine($"Ordered by {_customer.ReturnCustomerName()}");
    foreach(Product product in _products)
    {
        product.DisplayItem();
    }
    Console.WriteLine($"Total: ${Math.Round(CalcOrderCost(), 2)}");
    Console.WriteLine($"Total including Shipping: ${Math.Round(TotalOrderCost(), 2)}");
 }

 public void ReturnShippingLabel()
 {
    Console.WriteLine($"Shipping Label: \nShip to {_customer.ReturnCustomerName()} \n{_customer.ReturnCustomerAddress()}");
 }

 public double TotalOrderCost()
 {
    double fullTotal = 0;
    string usOrNot = _customer.IfInUsa();
    if (usOrNot == "usa")
    {
        fullTotal = CalcOrderCost() + 5;
    }
    else
    {
        fullTotal = CalcOrderCost() + 35;
    }
    return fullTotal;
 }
}