using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenacao
{
    internal class Operacoes
    {

        public int[] Ordenar(int[] array) 
        {

            for (int i = 1; i < array.Length -1; i++)
            {
                bool troca = false;
               
                    if (array[i] > array[i +1]) 
                    {

                    int marca = array[i];
                    array[i] = array[i +1];
                    array[i +1] = marca;
                    troca = true;
                    }
            }
            return array;
        }
    }
}
