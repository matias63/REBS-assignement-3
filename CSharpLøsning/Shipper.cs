public class Shipper
{
    public event Action<string>? Details2Buy;

    public void DetailsBuyer(string message)
    {
        System.Console.WriteLine("Sending details to buyer");
        Details2Buy?.Invoke("Invoice for " + message);
        System.Console.WriteLine(message);
    }
}