using System;

namespace Examen
{

    class Objeto
    {
        public string nombreDelObjeto { get; set; }
        public int pesoDelObjeto { get; set; }
        public string inicial { get; set; }
        public Objeto(string nombreDelObjeto, int pesoDelObjeto, string inicial)
        {
            this.nombreDelObjeto = nombreDelObjeto;
            this.pesoDelObjeto = pesoDelObjeto;
            this.inicial = inicial;
        }

        public string Tomarnombre()
        {
            return nombreDelObjeto;
        }

        public int Tomarpeso()
        {
            return pesoDelObjeto;
        }

        public string Tomarinicial()
        {
            return inicial;
        }
    }
}