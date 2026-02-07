        class Pessoa
        {
            private string nome;
            private int idade;                                //criando objeto e declarando as variaveis

            public Pessoa()
            {
                nome = "";
                idade = 0;                // construtor default
            }

            public Pessoa(string nome_, int idade_)
            {
                nome = nome_;                        //construtor padrão
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

            public string pegar_nome()                        //metodos get e set
            {
                return nome;
            }

            public int pegar_idade()
            {
                return idade;
            }

            public void ExibirDados()
            {
                Console.WriteLine("Nome: " + nome);                        //função para imprimir os dados
                Console.WriteLine("Idade: " + idade);
            }
        }
