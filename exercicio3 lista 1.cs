using System;

class Program
{
    static void Main()
    {
        int altura = 5; 

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
