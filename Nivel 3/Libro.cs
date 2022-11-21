class Libro{

    string titulo;
    string autor;
    int ejemplaresLibro;
    int ejemplaresPrestados;

    public Libro(string titulo, string autor, int ejemplaresLibro, int ejemplaresPrestados) {

        this.titulo = titulo;
        this.autor = autor;
        this.ejemplaresLibro = ejemplaresLibro;
        this.ejemplaresPrestados = ejemplaresPrestados;

    }


    public string getTitulo() {
    
        return titulo;
    
    }


    public void setTitulo(string titulo) {

        this.titulo = titulo;

    }


    public string getAutor() {

        return autot;

    }


    public void setAtuor(string autor) {

        this.autor = autor;

    }

    public int getEjemplaresLibro() {

        return ejemplaresLibro;

    }

    public void setEjemplaresLibro(int ejemplaresLibro) {

        this.ejemplaresLibro = ejemplaresLibro;

    }


    public int getEjemplaresPrestados() {

        return ejemplaresPrestados;

    }

    public void setEjemplaresPrestados(int ejemplaresPrestados) {

        this.ejemplaresPrestados = ejemplaresPrestados;

    }

    public prestamo() {

        bool prestado;
        if(ejemplaresLibro > 0) {

            ejemplaresPrestados++;
            prestado = true;

        } else {

            prestado = false;

        }

        return prestado;

    }

    public devolucion() {

        bool retornado;
        if(ejemplaresPrestados > 0) {

            ejemplaresPrestados--;
            retornado = true;

        } else {

            retornado = false;

        }

        return retornado;

    }

    public mostrar() {

        Console.WriteLine(titulo);
        Console.WriteLine(autor);
        Console.WriteLine(ejemplaresLibro);
        Console.WriteLine(ejemplaresPrestados);

    }

}