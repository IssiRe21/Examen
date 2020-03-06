using System;

namespace Examen
{
    class Mochila
    {
        public Objeto[,] mochilaOrden;
        private int tamañoX;
        private int tamañoY;
        public Mochila(Objeto[,] mochilaOrden, int tamañoX, int tamañoY)
        {
            this.mochilaOrden = mochilaOrden;
            this.tamañoX = tamañoX;
            this.tamañoY = tamañoY;

        }

        public void MostrarMochila()
        {
            for (int y = 0; y < this.tamañoY; y++)
            {
                //iterar columnas
                for (int x = 0; x < this.tamañoX; x++)
                {
                    //imprimir 
                    Console.Write(mochilaOrden[y, x].Tomarinicial() + " ");
                }
                Console.WriteLine();
            }
        }
        public void ComprobarPeso()
        {
            //primera columna
            if (this.mochilaOrden[0, 0].Tomarpeso() != 0)
            {
                Console.Write("No puedes poner cosas en las esquinas superiores");
            }
            else
            {
                if (this.mochilaOrden[1, 0].Tomarpeso() > this.mochilaOrden[2, 0].Tomarpeso())
                {
                    Console.WriteLine(this.mochilaOrden[2, 0].Tomarnombre() + " se esta aplastando");
                }
                else
                {
                    Console.WriteLine("La columna 1 esta bien");
                }
            }

            //Segunda columna
            if (this.mochilaOrden[0, 1].Tomarpeso() == this.mochilaOrden[1, 1].Tomarpeso())
            {
                if (this.mochilaOrden[1, 1].Tomarpeso() > this.mochilaOrden[2, 1].Tomarpeso())
                {
                    Console.WriteLine(this.mochilaOrden[2, 1].Tomarnombre() + " se esta aplastando");
                }
                else
                {
                    Console.WriteLine("La columna 2 esta bien");
                }
            }
            else
            {
                if (this.mochilaOrden[1, 1].Tomarpeso() == this.mochilaOrden[2, 1].Tomarpeso())
                {
                    if (this.mochilaOrden[0, 1].Tomarpeso() > this.mochilaOrden[1, 1].Tomarpeso())
                    {
                        Console.WriteLine(this.mochilaOrden[1, 1].Tomarnombre() + " se esta aplastando");
                    }
                    else
                    {
                         Console.WriteLine("La columna 2 esta bien");
                    }
                }
                else
                {
                    if (this.mochilaOrden[0, 1].Tomarpeso() > this.mochilaOrden[1, 1].Tomarpeso())
                    {
                        Console.WriteLine(this.mochilaOrden[1, 1].Tomarnombre() + " se esta aplastando");
                    }
                    else
                    {
                        if (this.mochilaOrden[0, 1].Tomarpeso() + this.mochilaOrden[1, 1].Tomarpeso() > this.mochilaOrden[2, 1].Tomarpeso())
                        {
                            Console.WriteLine(this.mochilaOrden[2, 1].Tomarnombre() + " se esta aplastando");
                        }
                        else
                        {
                             Console.WriteLine("La columna 2 esta bien");
                        }
                    }
                }
            }

            //Tercera columna
            if (this.mochilaOrden[0, 2].Tomarpeso() == this.mochilaOrden[1, 2].Tomarpeso())
            {
                if (this.mochilaOrden[1, 2].Tomarpeso() > this.mochilaOrden[2, 2].Tomarpeso())
                {
                    Console.WriteLine(this.mochilaOrden[2, 2].Tomarnombre() + " se esta aplastando");
                }
                else
                {
                    Console.WriteLine("La columna 2 esta bien");
                }
            }
            else
            {
                if (this.mochilaOrden[1, 2].Tomarpeso() == this.mochilaOrden[2, 2].Tomarpeso())
                {
                    if (this.mochilaOrden[0, 2].Tomarpeso() > this.mochilaOrden[1, 2].Tomarpeso())
                    {
                        Console.WriteLine(this.mochilaOrden[1, 2].Tomarnombre() + " se esta aplastando");
                    }
                    else
                    {
                        Console.WriteLine("La columna 3 esta bien");
                    }
                }
                else
                {
                    if (this.mochilaOrden[0, 2].Tomarpeso() > this.mochilaOrden[1, 2].Tomarpeso())
                    {
                        Console.WriteLine(this.mochilaOrden[1, 2].Tomarnombre() + " se esta aplastando");
                    }
                    else
                    {
                        if (this.mochilaOrden[0, 2].Tomarpeso() + this.mochilaOrden[1, 2].Tomarpeso() > this.mochilaOrden[2, 2].Tomarpeso())
                        {
                            Console.WriteLine(this.mochilaOrden[2, 2].Tomarnombre() + " se esta aplastando");
                        }
                        else
                        {
                            Console.WriteLine("La columna 3 esta bien");
                        }

                    }
                }
            }

            // Cuarta columna
            if (this.mochilaOrden[0, 3].Tomarpeso() != 0)
            {
                Console.Write("No puedes poner cosas en las esquinas superiores");
            }
            else
            {
                if (this.mochilaOrden[1, 3].Tomarpeso() > this.mochilaOrden[2, 3].Tomarpeso())
                {
                    Console.WriteLine(this.mochilaOrden[2, 3].Tomarnombre() + " se esta aplastando");
                }
                else
                {
                    Console.WriteLine("La columna 4 esta bien");
                }
            }
            
        }
    }
}