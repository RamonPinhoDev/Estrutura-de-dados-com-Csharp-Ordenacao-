using System;

namespace Ordenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pontos = { 90,70,50,80,60,85};

            var op = new Operacoes();

            op.Ordenar(pontos);

            foreach (int i in pontos) 
            {
                Console.Write(i+", ");
            }

          }
    }
}