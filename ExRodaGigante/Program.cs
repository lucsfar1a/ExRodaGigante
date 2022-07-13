using System;

namespace ExRodaGigante
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante(); 
            Adulto paulo = new Adulto("Paulo", 42); 
            
            Crianca joao = new Crianca("Joao", 5, paulo); 
            Crianca maria = new Crianca("Maria", 12, paulo); 

            //Criança sem ID
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            roda.Embarcar(2, joao, maria);
            roda.Embarcar(2, joao, paulo);
            roda.Embarcar(3, maria);
            roda.Embarcar(13, pedro);
            roda.Embarcar(16, henrique);

            roda.status();

            Console.ReadKey();
        }
    }
}