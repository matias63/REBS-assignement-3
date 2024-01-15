// using the interface module BuyerServiceInterfaceModule
interface BuyerShipperInterface {
    OneWay:
        details( string)
}
interface BuyerSellerInterface {
    OneWay:
        quote( int)
}
// and the interface module SellerShipperServiceInterfaceModule
interface SellerInterface {
    OneWay:
        ask( string ),
        accept( string ),
        reject( string )
}
interface ShipperInterface {
    OneWay:
        order( string )
}