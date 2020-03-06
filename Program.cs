using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Objeto B = new Objeto("Brujula", 350, "B");
            Objeto PB = new Objeto("Papel de baño", 320, "PB");
            Objeto PL = new Objeto("Platano", 80, "PL");
            Objeto P = new Objeto("Pan", 70, "P");
            Objeto V = new Objeto("Vacio", 0, "V");
            Objeto C = new Objeto("Cuerda", 1000, "C");
            Objeto A = new Objeto("Botella de agua", 1100, "A");
            Objeto M = new Objeto("Manzana", 250, "M");

            Mochila mochila = new Mochila(
                new Objeto[3, 4]{
                   {V , M, P, V},
                   {PL, C, A, PB},
                   {PL, C, A, B}}, 4, 3
                 );

            mochila.MostrarMochila();
            mochila.ComprobarPeso();
            
        }
    }
}
