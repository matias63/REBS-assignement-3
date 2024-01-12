include "console.iol"
from BuyerServiceInterfaceModule import BuyerShipperInterface

main {
    while (true) {
        [order(order)] {
            details@Buyer(invoice)
            println@Console( "price for chips is" + price)
        } 
    }
}