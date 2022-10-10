using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal static class ExtenderLista
    {
        internal static void mostrarLista<T>(this List<T> lista)
        {
            foreach (Object obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
