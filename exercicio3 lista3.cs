        class Pessoa
        {
            private string nome;
            private int idade;

            public Pessoa()
            {
                nome = "";
                idade = 0;
            }

            public Pessoa(string nome_, int idade_)
            {
                nome = nome_;
                idade = idade_;
            }

            public void definir_nome(string comando)
            {
                nome = comando;
            }

            public void definir_idade(int comando)
            {
                idade = comando;
            }

            public string pegar_nome()
            {
                return nome;
            }

            public int pegar_idade()
            {
                return idade;
            }

            public void ExibirDados()
            {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
            }
        }
