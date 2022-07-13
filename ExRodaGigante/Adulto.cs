using System;
using System.Collections.Generic;
using System.Text;

namespace ExRodaGigante
{
    public class Adulto : Pessoa
    {
        public Adulto(string nome, int idade) : base(nome, idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}