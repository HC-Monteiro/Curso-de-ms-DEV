using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string hi = "Hello World";
            string nome = "Hugo cainã";
            var sobrenome = "Monteiro";
            Console.WriteLine(hi);
            Console.WriteLine(nome);
            // concatenação de strings
            Console.WriteLine(nome + " " + sobrenome);
            // interpolação de strings
            var nomeCompleto = $"{nome} {sobrenome}";
            Console.WriteLine(nomeCompleto);
            */
            
            /*
            Console.Write("Qual teu nome? ");
            var nome = Console.ReadLine();
            Console.WriteLine($"E aew, {nome}");
            */

            Console.Write("Quanto deu a conta? ");
            var conta = double.Parse(Console.ReadLine());
            Console.Write("Quantos porcentos é do garcom? ");
            var porcento = double.Parse(Console.ReadLine());
            var taxa = conta * porcento/100;
            var total = conta + taxa;
            Console.WriteLine(total);
        }
    }
}
