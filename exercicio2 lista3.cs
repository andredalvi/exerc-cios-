using System;
    class Program
    {
        class Ponto
        {
            private int coordenada_x;
            private int coordenada_y;

            public Ponto()
            {
                coordenada_x = 0;
                coordenada_y = 0;
            }

            public Ponto(int x, int y)
            {
                coordenada_x = x;
                coordenada_y = y;
            }

            public Ponto(Ponto outro_ponto)
            {
                coordenada_x = outro_ponto.pegar_x();
                coordenada_y = outro_ponto.pegar_y();
            }

            public void definir_x(int comando)
            {
                coordenada_x = comando;
            }

            public void definir_y(int comando)
            {
                coordenada_y = comando;
            }

            public int pegar_x()
            {
                return coordenada_x;
            }

            public int pegar_y()
            {
                return coordenada_y;
            }

            public void ExibirDados()
            {
                Console.WriteLine("X: " + coordenada_x + " Y: " + coordenada_y);
            }
        }
    }
