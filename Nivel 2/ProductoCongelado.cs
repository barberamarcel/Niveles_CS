class ProductoCongelado : Producto {

    super(int numeroProducto, int numeroLote);
    int temperaturaCongelacion;

    public ProductoFresco(int temperaturaCongelacion) {

        this.temperaturaCongelacion = temperaturaCongelacion;

    }

    public int getTemperaturaCongelacion() {

        return temperaturaCongelacion;

    }

    public void setTemperaturaCongelacion(int temperaturaCongelacion) {

        this.temperaturaCongelacion = temperaturaCongelacion;

    }

    public mostrar() {

        Console.WriteLine(Producto.getNumeroProducto);
        Console.WriteLine(Producto.getNumeroLote);
        Console.WriteLine(temperaturaCongelacion);

    }

}