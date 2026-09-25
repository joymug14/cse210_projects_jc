public class Product
{
    private string _productName;
    private string _productId;

    private double _price;

    private int _quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price; 
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

}