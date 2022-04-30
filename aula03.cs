using System;
using System.Globalization;

namespace aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola!,Escolha um numero de 1 a 5 ");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1 : Console.WriteLine("Vc teve sorte");break;
                case 2 : Console.WriteLine("Quase");break;
                case 3 : Console.WriteLine("Tente de novo");break;
                case 4 : Console.WriteLine("Parabéns");break;
                case 5 : Console.WriteLine("Errou moral");break;
                default : Console.WriteLine("Alternativa não encontrada");break;
            }
        }


        static void Else_IF()
        {
            // estrutura condicional - encadeamentos

            Console.WriteLine("Ola!, Que horas são? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
        static void IfElse()
        {
            // programa se o numero é par ou impar

            Console.WriteLine("Digite um numero: ");
            // .parse converte string em int 
            int numero = int.Parse(Console.ReadLine());

            // % = o resto da divisão
            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é PAR!");
            }
            else
            {
                Console.WriteLine("O numero é IMPAR!");
            }
        }
        static void IF()
        {

            // estrutura condicional

            int x = 15;

            Console.WriteLine("Boa Noite!!");

            if (x == 5)
            {
                Console.WriteLine("Let's go to the party");
            }

            Console.WriteLine("vai dormir q ta tarde!!");

        }
        static void SaidadeDados()
        {
            int idade = 30;
            double saldo = 25.85454;
            string nome = "Hugo";

            //Console.WriteLine(nome + " " + saldo + " " + idade);

            // placeholder - lugar para colocar a variavel

            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2} reais", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos de idade e saldo de {saldo} reais");

            // para colocar um maximo de casas decimais.
            Console.WriteLine("{0} tem {1} anos de idade e saldo de {2:F3} reais", nome, idade, saldo);

            // para trocar virgula por ponto
            Console.WriteLine(saldo.ToString("F3", CultureInfo.GetCultureInfo("pt-BR")));

        }
        static void Exercicio()
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0},cujo preço é R$ {1:C2}", produto1, preco1);// C2 converteu para moeda
            Console.WriteLine("{0},cujo preço é R$ {1}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro:");
            Console.WriteLine("{0} anos de idade, codigo {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("{0:F8}", medida);
            Console.WriteLine($"{medida:F3}");


            /*Usando os valores das variáveis, produza a seguinte saída na tela do console:
                
            Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preço é $ 650,50
            Registro: 
                30 anos de idade, código 5290 e gênero M
                Medida com oito casas decimais: 53,23456700
                Arredondado (três casas decimais): 53,235
            */

        }
    }
}
