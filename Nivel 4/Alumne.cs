using System.Collections;

class Alumne{

    string nom;
    string cognom;
    string NIF;
    string Cicle_Formatiu;
    string curs;

    public Alumne(string nom, string cognom, string NIF, string Cicle_Formatiu, string curs) {

        this.nom = nom;
        this.cognom = cognom;
        this.NIF = NIF;
        this.Cicle_Formatiu = Cicle_Formatiu;
        this.curs = curs;

    }

    public toString() {

        Console.WriteLine(nom);
        Console.WriteLine(cognom);
        Console.WriteLine(NIF);
        Console.WriteLine(Cicle_Formatiu);
        Console.WriteLine(curs);

    }

    public string getNom() {

        return nom;

    }

    public void setNom(string nom) {

        this.nom = nom;

    }

    public string getCognom() {

        return cognom;

    }

    public void setCognom(string cognom) {

        this.cognom = cognom;

    }

    public string getNIF() {

        return NIF;

    }

    public void setNIF(string NIF) {

        this.NIF = NIF;

    }

    public string getCicle_Formatiu() {

        return Cicle_Formatiu;

    }

    public void setCicle_Formatiu(string Cicle_Formatiu) {

        this.Cicle_Formatiu = Cicle_Formatiu;

    }

    public string getCurs() {

        return curs;

    }

    public void setCurs(string curs) {

        this.curs = curs;

    }

    public equals() {

        Alumne = (nom == nom) && (cognom == cognom) && (NIF == NIF);

    }

    public TestMain() {

        ArrayList alu = new ArrayList();
        alu.Add(nom);
        alu.Add(cognom);
        alu.Add(NIF);
        alu.Add(Cicle_Formatiu);
        alu.Add(curs);

        alu.IndexOf(nom);
        alu.IndexOf(cognom);
        alu.IndexOf(NIF);
        alu.IndexOf(Cicle_Formatiu);
        alu.IndexOf(curs);

        Console.WriteLine(string.Join(", ", alu));

    }

}