using ClosedXML.Excel;
using System;
using System.IO; // biblioteca para ler o comando FileStream
using System.Linq;

namespace aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enderecoArquivo = @"C:\Users\hugo_\OneDrive\Documentos\formação ms-dev\projetos\aula07\banco_de_dados.xlsx";

            XLWorkbook arquivoExcel = new XLWorkbook(enderecoArquivo);
            IXLWorksheet planilha = arquivoExcel.Worksheets.First(w => w.Name == "Plan1");

            int totalLinhas = planilha.Rows().Count();

            for (int l = 2; l < totalLinhas; l++)
            {
                var nome = planilha.Cell($"A{l}").Value.ToString();
                var idade = planilha.Cell($"B{l}").Value.ToString();
                var especialidade = planilha.Cell($"C{l}").Value.ToString();
                Console.WriteLine($"Nome: {nome}, Idade: {idade} anos, Especialidade: {especialidade}");
            }

        }
            
        static void Leituratxt()
        {
                /* Ler dados de um arquivo local
                             *  '\' o C# aguarda um comando especial
                             *  
                             *  @ ou \\ para ñ entender como sendo um comando especial
                             *  string localArquivo = "C:\\Users\\hugo_\\OneDrive\\Documentos\\formação ms-dev\\projetos\\aula07\\dados.txt"
                             */

                string localArquivo = @"C:\Users\hugo_\OneDrive\Documentos\formação ms-dev\projetos\aula07\dados.txt";

                //FileStream classe que esta instanciando
                //esta orientando onde esta o arquivo e o q é pra fazer

                //preparação do arquivo
                FileStream arquivo = new FileStream(localArquivo, FileMode.Open);

                //classe que vai ler o arquivo preparado (stream)
                StreamReader leitor = new StreamReader(arquivo);

                // While = estrutura de repetição
                // leitor.EndOfStream(bool) = informa que terminou de ler

                // percorrer o arquivo ate terminar de ler

                // é pra permanecer no while apenas enqnt o EndOfStream for FALSE
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();

                    Profissional novoProfissional = ConverterStringParaProfissional(linha);

                    // interpolação '$' tera codigo C# no meio da string
                    string mensagem = ($"Nome: {novoProfissional.nome}, Idade: {novoProfissional.idade} anos, Especialidade: {novoProfissional.especialidade}");

                    Console.WriteLine(mensagem);

                }

                // liberar o processo do arquivo e do leitor.
                arquivo.Close();
                leitor.Close();

        }

        // criar uma função q vai receber um texto e devolver o profissional

        static Profissional ConverterStringParaProfissional(string linha)
        {
            
            // Hugo 30 mobile
                                //SPLIT divide a string de acordo com um padrão, nesse caso espaço
            string[] campos=linha.Split(' ');
            
            Profissional profissional = new Profissional();
            profissional.nome = campos[0];
            profissional.idade = int.Parse(campos[1]);
            profissional.especialidade = campos[2];

            return profissional;

        }
 

        class Profissional
        {
            // atalho prop e TAB TAB

            // GET = leitura da propriedade;
            // SET = armazenar um valor para a propriedade;

            public string nome { get; set; }
            public int idade { get; set; }
            public string especialidade { get; set; }



        }
    }
}
