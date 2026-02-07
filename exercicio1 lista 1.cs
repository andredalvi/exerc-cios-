using System;
using System.Reflection.Metadata;

namespace exercicio3
{
    class Program
    {
        static void Main()
        {
            int soma = 0, contador = 0;            
            do    
            {
                Console.WriteLine(soma);
                soma += soma + 1;
                contador++;
            } while(contador <30);
        }
    }
}