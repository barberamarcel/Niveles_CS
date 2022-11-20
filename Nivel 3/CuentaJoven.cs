class CuentaJoven {

    string titular;
    double cantidad;
    int edad;

    public CuentaJoven(string titular, double cantidad, int edad) {

        this.titular = titular;
        this.cantidad = cantidad;
        this.edad = edad;

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


    public void setCantidad() {

        this.cantidad = cantidad;

    }

    public int getEdad() {

        return edad;

    }

    public void setEdad(int edad) {

        this.edad = edad;

    }

    public esTitularValido() {

        bool edadValida;
        if(edad >= 18 && edad <= 25) {

            edadValida = true;

        } else {

            edadValida = false;

        }

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
        if(cantidad > 0 && esTitularValido.edadValida = true) {

            cantidad -= retiro;

        } else {
            
        }

    }

    public mostrar() {

        Console.WriteLine(titular);
        Console.WriteLine(cantidad);
        Console.WriteLine(edad);

    }

}