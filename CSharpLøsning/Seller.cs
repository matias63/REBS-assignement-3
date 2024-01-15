public class Seller
{
    public event Action<string>? Quote2Buy;
    public event Action<string>? Order2Ship;

    public void QuoteBuyer(string message)
    {
        // Logic to determine the actual price
        string actualPrice = DetermineActualPrice();

        Quote2Buy?.Invoke(actualPrice);
    }

    public void OrderShipper(string message)
    {
        System.Console.WriteLine("Sending order to shipper");
        Order2Ship?.Invoke(message);
    }

    // Logic to determine the actual price (replace with your implementation)
    private string DetermineActualPrice()
    {
        // Replace this with your logic to calculate the actual price
        System.Console.WriteLine("Input price:");
        String? price = Console.ReadLine();
        System.Console.WriteLine("The price is:" + price);
        return price;
    }
}