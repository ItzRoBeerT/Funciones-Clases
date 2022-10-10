using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal static class ExtenderString
    {
        //Con this y nombre del objeto le indicamos donde lo queremos agregar 
        internal static void imprimirPantalla(this string? s) 
        {
            Console.WriteLine(s);
        }
    }
}
