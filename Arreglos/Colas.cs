using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        public string[] array;
        private int max;
        public int principio;
        public int final;
        public Colas(int tamano)
        {
            array= new string[tamano];
            max= array.Length - 1;
            principio= 0;
            final= 0;
        }

    }
}
