include "console.iol"
from BuyerServiceInterfaceModule import BuyerShipperInterface, BuyerSellerInterface

include "console.iol"
service SellerShipper {
    execution{ single }
    outputPort Shipper {
        location: "socket://localhost:8003"
        protocol: http { format = "json" }
        interfaces: ShipperInterface
    }
    inputPort BuyerSeller {
        location: "socket://localhost:8000"
        protocol: http { format = "json" }
        interfaces: SellerInterface
    }
    main{
        [ask(item)(15)]
        [accept(item)]{
            order@SellerShipper(item)}
        [reject(item)]
    }
}