SaleItem.MyResult();
public class SaleItem
{
    string _name;
    decimal _cost;

    public SaleItem(string name, decimal cost)
    {
        _name = name;
        _cost = cost;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public decimal Price
    {
        get => _cost;
        set => _cost = value;
    }

    public static void MyResult()
    {
        SaleItem[] items = new SaleItem[3];
        items[0] = new SaleItem("Apple", 1.99m);
        items[1] = new SaleItem("Orange", 2.99m);
        items[2] = new SaleItem("Banana", 3.99m);

        foreach (SaleItem item in items)
        {
            Console.WriteLine(item.Name + " " + item.Price);
        }
    }
}