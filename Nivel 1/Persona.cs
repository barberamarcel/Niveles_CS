class Persona {

    string nombre;
    int edad;
    string DNI;

    public Persona(string nombre, int edad, string DNI) {

        this.nombre = nombre;
        this.edad = edad;
        this.DNI = DNI;

    }

    public string getNombre() {

        return nombre;

    }

    public void setNombre(string nombre) {

        this.nombre = nombre;

    }

    public int getEdad() {

        return edad;

    }

    public void setEdad(int edad) {

        this.edad = edad;

    }

    public string getDNI() {

        return DNI;

    }

    public void setDNI(string DNI) {

        this.DNI = DNI;

    }

    public mostrar() {

        Console.WriteLine(nombre);
        Console.WriteLine(edad);
        Console.WriteLine(DNI);

    }

    public esMayorDeEdad() {

        if (edad >= 18) {

            return 1;

        }

    }

}