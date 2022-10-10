using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Clase
    {
        //CAMPOS
        private string? _nombre; //? para que no permita null
        int _edad;
        bool _carnet;

        //CONSTRUCTOR ctor->tab

        public Clase(string nombre, int edad, bool carnet)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carnet = carnet;
        }
        public Clase()
        {
            this.Nombre = "Manolo";
            this.Edad = 18;
            this.Carnet = true;
        }

        //Propiedades

        public string Nombre
        {
            get { return _nombre.ToUpper(); }
            set { _nombre = value; }
        }
        public int Edad { get; private set; } //readonly puedes eliminar el set tmb

        public bool Carnet { get; set; } = false; //poner un valor por defecto

        //Métodos

        internal void imprimirNombre()
        {

        }

        internal void imprimirNombre(bool a)  //al pasar por parámetros es por referencia
        {

        }

        public static void imprimir()
        {

        }
        
    }
}
