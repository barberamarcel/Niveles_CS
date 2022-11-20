class Cuenta{

    string titular;
    double cantidad;

    public Cuenta(string titular, double cantidad) {

        this.titular = titular;
        this.cantidad = cantidad;

    }

    public string getTitular() {

        return titular;

    }

    public void setTitular(string titular) {

        this.titular = titular;

    }

    public double getCantidad() {

        return cantidad;

    }

    public void setCantidad(double cantidad) {

        this.cantidad = cantidad;

    }

    public mostrar() {

        Console.WriteLine(titular);
        Console.WriteLine(cantidad);

    }

    public ingresar(double cantidad) {

        double ingreso;
        if(ingreso > 0) {

            cantidad += ingreso;

        } else {

        }

    }

    public retirar(double cantidad) {

        double retiro;
        if(cantidad > 0) {

            cantidad -= retiro;

        } else {
            
        }

    }

}