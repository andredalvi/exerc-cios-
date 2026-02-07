using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace exercicio
{
    class Program
    {
        class Veiculo
        {
            private int assentos;
            private int quantidade_rodas;
            private int quantidade_lt_tanque;           // declarando variaveis do objeto
            private int percentual_gasolina;
            private float kilometragem;
            private float consumo_medio;
            public Veiculo()
            {
                assentos = 0;
                quantidade_rodas = 0;
                quantidade_lt_tanque = 0;           // construtor default para inicializar as variaveis
                percentual_gasolina = 0;
                kilometragem = 0;
                consumo_medio = 0;
            }
            public Veiculo(int assent, int qta_rodas, int qta_lt_tanq, int perc_gaso, float kilom, float consumo_med)
            {
                assentos = assent;
                quantidade_rodas = qta_rodas;
                quantidade_lt_tanque = qta_lt_tanq;         // construtor completo que passa valores com correção na kilometragem
                percentual_gasolina = perc_gaso;
                if(kilom <= 999999)
                {
                    kilometragem = kilom;
                }
                consumo_medio = consumo_med;
            }
            public void definir_assen (int comando)
            {
                assentos = comando;
            }
            public void definir_rodas (int comando)         // metodos set para passar valores para o objeto
            {
                quantidade_rodas = comando;
            }
            public void definir_lt_tanq (int comando)
            {
                quantidade_lt_tanque = comando;
            }
            public void definir_quantidade_gaso (int comando)
            {
                percentual_gasolina = comando;
            }
            public void definir_kilometragem (int comando)
            {
                kilometragem = comando;
            }
            public void definir_consumo_medio (float comando)
            {
                consumo_medio = comando;
            }
            public int pegar_assentos()
            {
                return assentos;
            }
            public int pegar_quantidade_rodas()         //metodos get para pegar valores dentro do objeto
            {
                return quantidade_rodas;
            }
            public int pegar_quantodade_lt_tanques()
            {
                return quantidade_lt_tanque;
            }
            public int pegar_percentual_gasolina()
            {
                return percentual_gasolina;
            }
            public float pegar_kilometragem()
            {
                return kilometragem;
            }
            public float pegar_consumo_medio()
            {
                return consumo_medio;
            }
            public float Percorrerkilometragem(float comando)
            {
                kilometragem += comando;
                return kilometragem;
            }
        }
        class Car : Veiculo
        {
            private string nome_carro = "";             //criação de uma subclasse com a herança de veiculo 
            private int qta_portas = 0;
            public Car() : base()
            {                       
                nome_carro = "";              //contrutor default
                qta_portas = 0;
            }
            public void name_car (string nome)
            {
                nome_carro = nome;
            }
            public void qta_portas_(int comando)        //metodos set do objeto
            {
                qta_portas = comando;
            }
            public Car(string name, int quantidade_portas, int assentos, int quantidade_rodas, int quantidade_lt_tanque_, int percentual_gasolina_, float kilometragem_, float consumo_medio) : base (assentos, quantidade_rodas, quantidade_lt_tanque_, percentual_gasolina_, kilometragem_, consumo_medio)
            {   
                nome_carro = name;
                qta_portas = quantidade_portas;         //construtor completo do objeto
            }
            public string pegar_nome()
            {
                return nome_carro;
            }
            public int pegar_portas()       //metodos get do objeto
            {
                return qta_portas;
            }
        }
        static void Main()
        {
            float rodado = 0;
            Veiculo ferrari = new Veiculo(2,4,50,20,500000,2);      //declarando qualquer valor para teste 
            Console.WriteLine(ferrari.pegar_kilometragem());
            rodado = ferrari.Percorrerkilometragem(500.2f);
            Console.WriteLine(ferrari.pegar_kilometragem());

        }
    }
}