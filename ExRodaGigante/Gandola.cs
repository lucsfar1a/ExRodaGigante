using System;
using System.Collections.Generic;
using System.Text;

namespace ExRodaGigante
{
    public class Gondola
    {
        public int Numero { get; set; }

        public Crianca Assento1 { get; set; }

        public Pessoa Assento2 { get; set; }

        public Gondola()
        {

        }

        public Gondola(int numero, Crianca assento1, Pessoa assento2)
        {
            Numero = numero;
            Assento1 = assento1;
            Assento2 = assento2;
        }

        public Gondola(int numero, Crianca assento1)
        {
            Numero = numero;
            Assento1 = assento1;
        }
    }
}