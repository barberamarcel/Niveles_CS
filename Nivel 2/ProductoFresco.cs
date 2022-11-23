class ProductoFresco : Producto {

    super(int numeroProducto, int numeroLote);
    int fechaEnvasado;
    string paisOrigen;

    public ProductoFresco(int fechaEnvasado, string paisOrigen) {

        this.fechaEnvasado = fechaEnvasado;
        this.paisOrigen = paisOrigen;

    }

    public int getFechaEnvasado() {

        return fechaEnvasado;

    }

    public void setFechaEnvasado(int fechaEnvasado) {

        this.fechaEnvasado = fechaEnvasado;

    }

    public string getPaisOrigen() {

        return paisOrigen;

    }

    public void setPaisOrigen(int paisOrigen){

        this.paisOrigen = paisOrigen;

    }

    public mostrar() {

        Console.WriteLine(Producto.getNumeroProducto);
        Console.WriteLine(Producto.getNumeroLote);
        Console.WriteLine(fechaEnvasado);
        Console.WriteLine(paisOrigen);

    }

}