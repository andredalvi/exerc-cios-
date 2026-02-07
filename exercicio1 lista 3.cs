using System;

namespace exercicio1
{
    class Program
    {
        class Retangulo
        {
            private float base_ret;
            private float altura_ret;                      //declarando as variaveis do objeto

            public Retangulo()
            {
                base_ret = 0;                  // construtor default
                altura_ret = 0;
            }

            public Retangulo(float b, float h)
            {
                base_ret = b;
                altura_ret = h;            //construtor completo
            }

            public void definir_base(float comando)
            {
                base_ret = comando;
            }

            public void definir_altura(float comando)
            {
                altura_ret = comando;
            }

            public float pegar_base()
            {
                return base_ret;                                    //metodos get e set para cada variavel
            }

            public float pegar_altura()
            {
                return altura_ret;
            }

            public float pegar_area()
            {
                return base_ret * altura_ret;
            }

            public void Mostrar_Dados()
            {
                Console.WriteLine("Base: " + base_ret);
                Console.WriteLine("Altura: " + altura_ret);                //metodo para imprimir cada medida do retangulo
                Console.WriteLine("Area: " + pegar_area());
            }
        }

        static void Main()
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Informe a base: ");
            retangulo.definir_base(float.Parse(Console.ReadLine()!));

            Console.Write("Informe a altura: ");
            retangulo.definir_altura(float.Parse(Console.ReadLine()!));

            retangulo.Mostrar_Dados();
        }
    }
}
