using System;

namespace exercicio
{
    class Program
    {
        static void Main()
        {
            int soma = 1, contador = 0, soma2 = 0, resultado = 0;            //declarando variaveis
            do    
            {
                Console.WriteLine(resultado);
                resultado = soma2 + soma;
                soma2 = soma;                    //do-while para printar a sequencia
                soma = resultado;
                contador++;
            } while(contador < 30);
        }
    }
}
