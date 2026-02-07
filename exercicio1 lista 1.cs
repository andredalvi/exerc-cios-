using System;

class Program
{
    static void Main()
    {
        string nome = "";
        Console.WriteLine("digite seu nome");
        nome = Console.ReadLine();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(nome);
        }
    }
}
