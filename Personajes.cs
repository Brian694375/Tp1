using System;

namespace Nueva_carpeta
{
    public class Personajes
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }


        public Personajes(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }


        public virtual void Atacar()
        {
            Console.WriteLine($"{Nombre} ataca al oponente");
        }


        public void RecibirDanio(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nombre} recibe {dano} de daño");
        }
    }
}


