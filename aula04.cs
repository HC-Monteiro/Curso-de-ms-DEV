using System;

namespace aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array();
            //FOR();
            //DoWhile01();
            //While_Debug();
            //SwitchCase();
        }
        static void Array()
        {
            //Array ("Vetor") é uma sequencia nao ordenada de itens.
            //Todos os itens em um array devem ser do mesmo tipo.

            int[] numeros_loteria = { 10, 5, 45, 12, 1, 8, 11 };

            //indice|posição

            //0 = 10;
            //1 = 5;
            //2 = 45;

            //Console.WriteLine(numeros_loteria[0]);     


            for (int i = 0; i <numeros_loteria.Length; i++)
            {
                Console.WriteLine(numeros_loteria[i]);
            }
        }
        static void For()
        {
            int i;

            /*i = 1 valor inicial
             * i <= 50 condição para analise
             * i++ = i=i+1
             */

            for (i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void DoWhile02()
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}", numero);
            }
            while (numero != 10);
        }
        static void DoWhile01()
        {
            int numero = 5;
            do
            {
                Console.WriteLine(numero);
                numero++; // = numero = numero+1
            }
            while (numero <= 20);
        }
        static void While_Debug()
        {
            /* F9 indica um breakpoint
             * F10 executa o programa linha por linha
             */
            
            Console.WriteLine("Digite um numero");
            int numero, soma;
            numero = int.Parse(Console.ReadLine());
            soma = 0;

            while (numero != 0)
            {
                soma = soma + numero;
                Console.WriteLine("Digite um numero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos numeros digitados é {0}", soma);
        }
        static void SwitchCase()
        {
            Console.WriteLine("Maceió/AL a Recife/PE");
            Console.WriteLine("Qual meio de transporte: \n [a]=Avião \n | [c]=Carro \n | [o]=Ônibus");

            char escolha;
            int tempo = 0;
            //string para char  //ToLower() converte para minusculo
            //ToUpper() converte para maiusculo
            escolha = char.Parse(Console.ReadLine().ToLower());

            switch (escolha)
            {
                case 'a': tempo = 30; break;
                case 'c': tempo = 120; break;
                case 'o': tempo = 360; break;
                default: tempo = -1; break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Não possuimos esse transporte");
            }
            else
            {
                Console.WriteLine("A viagem ira durar {0} minutos", tempo);
            }
        }
    }
}
