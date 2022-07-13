using System;
using System.Collections.Generic;
using System.Text;

namespace ExRodaGigante
{
    public class RodaGigante
    {
        public List<Gondola> ListaGondolas = new List<Gondola>();

        public void Embarcar(int numero, Crianca crianca1, Pessoa crianca2 = default)
        {
            Gondola GondolaPreenchida = ValidarEmbarcar(numero, crianca1, crianca2);

            if (ListaGondolas.Count == 0)
            {
                for (int i = 0; i < 18; i++)
                {
                    ListaGondolas.Add(new Gondola(i + 1, new Crianca(), new Pessoa()));
                }
            }

            this.AtualizarLista(GondolaPreenchida);
        }

        private Gondola ValidarEmbarcar(int numero, Crianca crianca1, Pessoa crianca2)
        {
            Gondola GondolaPreenchida = new Gondola();
            GondolaPreenchida.Numero = numero;

            if (crianca1.Idade >= 12 && crianca2 == default)
            {
                GondolaPreenchida.Assento1 = crianca1;
            }
            else if (crianca1.Idade >= 12 && crianca2.Idade >= 12)
            {
                GondolaPreenchida.Assento1 = crianca1;
                GondolaPreenchida.Assento2 = crianca2;
            }
            else if (crianca1.Idade < 12 && crianca1.Responsavel != null)
            {
                GondolaPreenchida.Assento1 = crianca1;
                GondolaPreenchida.Assento2 = crianca1.Responsavel;
            }

            return GondolaPreenchida;
        }

        private void AtualizarLista(Gondola gondola)
        {
            ListaGondolas[gondola.Numero - 1].Assento1 = gondola.Assento1;
            ListaGondolas[gondola.Numero - 1].Assento2 = gondola.Assento2;
        }

        public void status()
        {
            foreach (Gondola item in ListaGondolas)
            {
                if (item.Assento1 == null)
                    Console.WriteLine(item.Numero + " (vazia)");

                else if (item.Assento1 != null && item.Assento2 == null)
                {
                    Console.WriteLine(item.Numero + " Somente " + item.Assento1.Nome);
                    continue;
                }
                else if (item.Assento1.Nome == null && item.Assento2.Nome == null)
                    Console.WriteLine(item.Numero + " (vazia)");

                else if (item.Assento1.Nome != null && item.Assento2.Nome != null)
                    Console.WriteLine(item.Numero + " " + item.Assento1.Nome + " e " + item.Assento2.Nome);
            }
        }
    }
}