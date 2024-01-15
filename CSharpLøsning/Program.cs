class Program
{
    static void Main()
    {
        Buyer buyer = new Buyer();
        Seller seller = new Seller();
        Shipper shipper = new Shipper();

        buyer.Ask2Sell += seller.QuoteBuyer;
        seller.Quote2Buy += buyer.AcceptOrReject;
        seller.Order2Ship += shipper.DetailsBuyer;

        // Subscribe to the OrderRequest event to handle the order processing
        buyer.OrderRequest += () => seller.OrderShipper("Order the product");

        // Perform interactions
        buyer.AskSeller("Can I buy x item?");
    }
}
