namespace Nueva_carpeta;

public class MagoHielo : Personajes

{

    public int Magia { set;get; }

    public MagoHielo( string nombre, int vida, int magia) : base(nombre,vida)
    {

        this.Magia = magia;

    }

    public override void Atacar()
    {
        Console.WriteLine($"{Nombre} con su magia saca un plus de {Magia} daño");
    }

}
