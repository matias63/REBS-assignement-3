include "console.iol"
from BuyerServiceInterfaceModule import BuyerSellerInterface



main {
    while (true) {
        [ask(product)] {
            quote@Buyer(price)
            println@Console( "price for chips is" + price)
        } 
        [accept(order)]{
            [order(order)]
            println@Console( "requested order" + order)
        }
    }
}



