using System;
using System.Collections.Generic;
using System.Text;

namespace ExRodaGigante
{
    public class Crianca : Pessoa
    {
        public Adulto Responsavel { get; set; }

        public Crianca(string nome, int idade, Adulto responsavel) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
            Responsavel = responsavel;
        }

        public Crianca(string nome, int idade) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Crianca()
        {

        }
    }
}