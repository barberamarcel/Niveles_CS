class Producto{

    int numeroProducto;
    int numeroLote;

    public Producto(int numeroProducto, int numeroLote) {

        this.numeroProducto = numeroProducto;
        this.numeroLote = numeroLote;

    }

    public int getNumeroProducto() {

        return numeroProducto;

    }

    public void setNumeroProducto(int numeroProducto) {

        this.numeroProducto = numeroProducto;

    }

    public int getNumeroLote() {

        return numeroLote;

    }

    public void setNumeroLote(int numeroLote) {

        this.numeroLote = numeroLote;

    }

    public mostrar() {

        Console.WriteLine(numeroProducto);
        Console.WriteLine(numeroLote);

    }

}