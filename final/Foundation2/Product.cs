using System;

public class Product
{
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _quantity;
    public Product(string productName, int productID, double productPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        double _totalPrice = _productPrice * _quantity;
        return _totalPrice;
    }
}