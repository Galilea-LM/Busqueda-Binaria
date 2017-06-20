using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6Busqueda_Binaria
{
    class Vector
    {
        private int[] vector;
        public int comparaciones { get; set; }
        private int tamano;
        private int limSuperior ;
        private int limInferior = 0; 
        private int marcadorMedio;

        public Vector(int tamano)
        {
            this.tamano = tamano;
            vector = new int[tamano];
        }

        public void Llenar(int limite)
        { 
            Random aleatorio = new Random();
            for (int i = 0; i < tamano-1; i++)
            {
                vector[i] = aleatorio.Next(0, limite - 1);
            }     
        }
        public void Ordenar()
        {
            Array.Sort(vector);
        }

        public int busquedaBinaria(int numero)
        {
            limSuperior = tamano - 1;
            int busqueda = -1;
            while(limInferior<= limSuperior)
            {
                marcadorMedio = (limSuperior + limInferior) / 2;
                comparaciones++;
                if (vector[marcadorMedio] == numero)
                {
                    busqueda = marcadorMedio;
                    break;
                }
                else if (vector[marcadorMedio] < numero)
                {
                    limInferior = marcadorMedio + 1;
                }
                else
                {
                    limSuperior = marcadorMedio - 1;
                }
            }
                return busqueda;     
        }
        
        public override string ToString()
        {
            string mostrar = "";
            for (int i = 0; i < tamano; i++)
            {
                mostrar += "[" + i + "]--" + vector[i] + Environment.NewLine;
            }
            return mostrar;
        }
    }

}
