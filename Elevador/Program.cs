using System;

namespace Elevador
{
    class Program : Elevador
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();
            elevador.Inicio();
            elevador.Entrar();
        }
    }
}
