using System;

public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private float _price;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetproductId()
    {
        return _productId;
    }
    public void SetProductId(string productId)
    {
        _productId = productId;
    }


    public float GetTotalCost()
    {
        return _price * _quantity;
    }
}
