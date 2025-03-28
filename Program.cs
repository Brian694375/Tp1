namespace Nueva_carpeta;

class Program
{
    static void Main(string[] args)
    {


        MagoHielo MagoHielo = new MagoHielo("Manu",80,20);

        Pekka Pekka = new Pekka("dark",120,60);

        Pekka.Atacar();
        MagoHielo.Atacar();

        MagoHielo.RecibirDanio(60);

        if(Pekka.Vida>MagoHielo.Vida)
        {
            Console.WriteLine("Gano el P.E.K.K.A");
        }
        else
        {
            Console.WriteLine("Gano el Mago");
        }
    }
}
