        class Animal
        {
            private string nome;
            private string tipo;

            public Animal()
            {
                nome = "";
                tipo = "peixe";
            }

            public Animal(string nome_, string tipo_)
            {
                nome = nome_;

                if (tipo_ == "cachorro" || tipo_ == "gato" || tipo_ == "peixe")
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
                if (comando == "cachorro" || comando == "gato" || comando == "peixe")
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
                return nome;
            }

            public string pegar_tipo()
            {
                return tipo;
            }
        }
