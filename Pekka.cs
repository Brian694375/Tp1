namespace Nueva_carpeta;

public class Pekka : Personajes

{

    public int Espada { set;get; }

    public Pekka( string nombre, int vida, int espada) : base(nombre,vida)
    {

        this.Espada = espada;

    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} con su larga espada saca un plus de {Espada} daño");
    }

}
