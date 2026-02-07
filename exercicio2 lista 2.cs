using System;
using System.Runtime.InteropServices;

namespace exercico2
{
    class Program
    {
        class Corpoceleste
        {
            private int massa;
            private int densidade;
            private int posiçãoX;                   //criação da classe e seus atributos
            private int posiçãoY;
            private double raio;

            public Corpoceleste()
            {
                massa = 0;
                densidade = 0;              // construtor default 
                posiçãoX = 0;
                posiçãoY = 0;
                raio = 0;
            }
            public Corpoceleste(int massa_, int densidade_, int posiçãoX_, int posiçãoY_, double raio_)
            {
                massa = massa_;
                densidade = densidade_;
                posiçãoX = posiçãoX_;           //construtor completo 
                posiçãoY = posiçãoY_;
                raio = raio_;
            }
            public void set_massa(int comando)
            {
                massa = comando;
            }
            public void set_densidade(int comando)
            {
                densidade = comando;
            }
            public void set_posiçãoX(int comando)              //metodo set para passar valores por conta do encapsulamento
            {
                posiçãoX = comando;
            }
            public void set_posiçãoY(int comando)
            {
                posiçãoY = comando;
            }
            public void set_raio(double comando)
            {
                raio = comando;
            }
            public int get_massa()
            {
                return massa;                           //metodo get para pegar valores
            }
            public int get_densidade()
            {
                return densidade;
            }
            public int get_posiçãoX()
            {
                return posiçãoX;
            }
            public int get_posiçãoY()
            {
                return posiçãoY;
            }
            public double get_raio()
            {
                return raio;
            }
        }
        static void Main()
        {
            int maior_massa = 0, maior_corpo1 = 0, maior_corpo2 = 0;
            double dif_distancia = 0, raio = 0, maior_raio = 0, maior_dif_dista = 0;             //declarando variaveis e criando array de corpos
            Corpoceleste[] corpo = new Corpoceleste[10];
            for(int z = 0; z < 10; z++)
            {
                corpo[z] = new Corpoceleste();              // colocando um valor null para criar os 10 objetos 
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"qual a massa do {i + 1} corpo");
                corpo[i].set_massa(int.Parse(Console.ReadLine()!));
                Console.WriteLine($"qual a densidade do {i + 1} corpo");            
                corpo[i].set_densidade(int.Parse(Console.ReadLine()!));     //inserindo os valores que o usuario colocar
                Console.WriteLine($"qual a posiçãoX do {i + 1} corpo");
                corpo[i].set_posiçãoX(int.Parse(Console.ReadLine()!));
                Console.WriteLine($"qual a posiçãoY do {i + 1} corpo");
                corpo[i].set_posiçãoY(int.Parse(Console.ReadLine()!));
                raio = Math.Pow((3 * corpo[i].get_massa()) / (4 * Math.PI * corpo[i].get_densidade()), 1.0/3.0);    //calculando o raio com a biblioteca math
                corpo[i].set_raio(raio);
                if(corpo[i].get_massa() > maior_massa)
                {
                    maior_massa = corpo[i].get_massa();
                }
                if(corpo[i].get_raio() > maior_raio)                            // separando os corpos de maiores massa e o de maior raio
                {
                    maior_raio = corpo[i].get_raio();
                }
            }
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    dif_distancia = Math.Abs(corpo[x].get_posiçãoX() - corpo[y].get_posiçãoX());        // for duplo para calcular todas as possibilidades de planetas e suas diferentes distancias
                    if(dif_distancia > maior_dif_dista)
                    {
                        maior_corpo1 = x;
                        maior_corpo2 = y;
                    }
                }
            }
            Console.WriteLine($" o maior corpoceleste em massa foi o {maior_massa} ");       //exibindo respostas 
            Console.WriteLine($" o corpo de maior raio foi {maior_raio} ");
            Console.WriteLine($" os dois mais distantes foram o {maior_corpo1} e {maior_corpo2} ");
        }
    }
}