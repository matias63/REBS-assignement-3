

interface Iface {
    requestResponse: hello(void)(string)
}

service Main {


    inputPort IP {
        location: "local"
        protocol: "sodep"
        interfaces: Iface
    }

    execution: concurrent

	main {
        [hello()(res) {
            res = "World"
        }]
	}

}
