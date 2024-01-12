include "console.iol"
from BuyerServiceInterfaceModule import BuyerShipperInterface, SellerShipperInterface


include "console.iol"
service ShipperBuyer {
    execution{ single }
    outputPort Shipper {
        location: "socket://localhost:8001"
        protocol: http { format = "json" }
        interfaces: BuyerShipperInterface
    }
    inputPort SellerShipper {
        location: "socket://localhost:8003"
        protocol: http { format = "json" }
        interfaces: SellerShipperInterface
    }
    main{
        [order(product)]{
            details@ShipperBuyer(invoice)
        }
    }
}