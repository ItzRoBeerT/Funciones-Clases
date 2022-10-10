using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Coche
    {
        private string marca;
        private DateTime ano;
        private int velocidad, vMax;

        public Coche(string marca)
        {
            this.marca = marca;
            this.velocidad=0;
            this.ano = DateTime.Now;
        }
        public Coche()
        {
            this.marca = "Marca 1";
            this.velocidad = 0;
            this.ano = DateTime.Now;
        }

        public string Marca
        {
            get { return marca; }   
            set { marca = value; }  
        }

        public DateTime Ano
        {
            get { return ano; }
        }

        public int Velocidad
        {
            get { return velocidad;}
            set { velocidad = value; }  
        }

        public int Vmax
        {
            get { return vMax;}

            init {vMax = 120;}
        }

        public void acelerar(int incremento)
        {
            if(incremento == default)
            {
                if (this.Vmax < 120)
                {
                    this.velocidad++;
                }
                else Console.Write("Superas la velocidad maxima");
            }
            else
            {
                if ((this.velocidad + incremento) < 120)
                {
                    this.velocidad += incremento;
                }
                else Console.Write("Superas la velocidad maxima");
            }
                
        }
        //Con función lanmbda
        public void detener() => this.velocidad = 0;
  
    }
}
