public class Buyer
{
    public event Action<string>? Ask2Sell;

    public void AskSeller(string message)
    {
        System.Console.WriteLine("Buyer asks seller for price");
        Ask2Sell?.Invoke(message);
    }


    public void AcceptQuote(string message)
    {
        // Buyer accepts the quote
        Console.WriteLine($"Buyer accepts the quote: {message}");

        // Prompt the Seller to send the order to the Shipper
        OnOrderRequest();
    }

    public void RejectQuote()
    {
        // Buyer rejects the quote
        Console.WriteLine("Buyer rejects the quote");
    }

    public void AcceptOrReject(string message) {
        if (Convert.ToInt32(message) < 20) {
            AcceptQuote(message);
        }
        else {
            RejectQuote();
        }
    }

    // Event to signal the Seller to send the order to the Shipper
    public event Action? OrderRequest;

    protected virtual void OnOrderRequest()
    {
        OrderRequest?.Invoke();
    }
}