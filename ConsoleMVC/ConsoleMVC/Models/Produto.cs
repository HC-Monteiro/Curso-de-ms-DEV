using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMVC.Models
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //const valor unico que ñ pode ser alterado
        //csv - valores separados por virgulas
        private const string caminhodobanco = "DataBase/Produto.csv";


        //CTRL+K+D = alinhar o codio
        //'ctor' - cria um construtor - qnd construimos uma class (new()) esse metodo é acionado

        public Produto()
        {

            string pasta = caminhodobanco.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

            }
            if (!File.Exists(caminhodobanco))
            {
                File.Create(caminhodobanco);

            }
            
        }

        public List<Produto> Ler()
        {
            List<Produto> listaProdutos = new List<Produto>();

            string[] linhas = File.ReadAllLines(caminhodobanco);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(';');
                Produto novoProduto = new Produto();

                novoProduto.Codigo = int.Parse(atributos[0]);
                novoProduto.Nome = atributos[1];
                novoProduto.Preco = float.Parse(atributos[2]);

                listaProdutos.Add(novoProduto);
            }


            return listaProdutos;
        }
    }
}
