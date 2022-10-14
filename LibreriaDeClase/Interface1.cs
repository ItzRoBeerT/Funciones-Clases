using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClase
{
    internal interface Interface1
    {
        void MiMetodo();
        string MiMetodo2(int x);
        bool MiPropiedad { get; set; }
    }

    internal class MiClase : Interface1
    {
        public bool MiPropiedad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MiMetodo()
        {
            throw new NotImplementedException();
        }

        public string MiMetodo2(int x)
        {
            throw new NotImplementedException();
        }
    }
}
