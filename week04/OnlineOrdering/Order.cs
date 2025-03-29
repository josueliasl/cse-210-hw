using System;
using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
        
    }

    public float GetTotalCost()
    {
        float totalCost = 0;
        foreach (var product in _products)
        {
            totalCost +=product.GetTotalCost();
        }
        if (_customer.IsInUSA() == true)
            {
                totalCost = totalCost + 5;
            }
            else{
                totalCost = totalCost + 35;
            }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += product.GetName() +"," + " " + product.GetproductId();
            
        };
        return label.Trim();
    }
    public string GetShippingLabel()
    {
       return _customer.GetFullAddress();
    }
}