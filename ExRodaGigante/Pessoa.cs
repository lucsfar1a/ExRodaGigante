using System;
using System.Collections.Generic;
using System.Text;

namespace ExRodaGigante
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}