class productoRefrigerado : Producto {

    super(int numeroProducto, int numeroLote);
    int codigoOrganismo;

    public ProductoFresco(int codigoOrganismo) {

        this.codigoOrganismo = codigoOrganismo;

    }

    public int getCodigoOrganismo() {

        return codigoOrganismo;

    }

    public void setCodigoOrganismo(int codigoOrganismo) {

        this.codigoOrganismo = codigoOrganismo;

    }

    public mostrar() {

        Console.WriteLine(Producto.getNumeroProducto);
        Console.WriteLine(Producto.getNumeroLote);
        Console.WriteLine(codigoOrganismo);

    }

}