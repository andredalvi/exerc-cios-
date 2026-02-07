        class Animal
        {
            private string nome;
            private string tipo;                        // criando objeto e as variaveis

            public Animal()
            {
                nome = "";
                tipo = "peixe";                //construtor default
            }

            public Animal(string nome_, string tipo_)
            {
                nome = nome_;

                if (tipo_ == "cachorro" || tipo_ == "gato" || tipo_ == "peixe")                // construtor padrão com o filtro de tipo, limitando a somente 3 tipos, ou convertendo qualquer outra entrada para peixe
                {
                    tipo = tipo_;
                }
                else
                {
                    tipo = "peixe";
                }
            }

            public void definir_nome(string comando)
            {
                nome = comando;
            }

            public void definir_tipo(string comando)
            {
                if (comando == "cachorro" || comando == "gato" || comando == "peixe")                        //metodo definir com if para limitar os tipos
                {
                    tipo = comando;
                }
                else
                {
                    tipo = "peixe";
                }
            }

            public string pegar_nome()
            {
                return nome;                        //metodos gets
            }

            public string pegar_tipo()
            {
                return tipo;
            }
        }
