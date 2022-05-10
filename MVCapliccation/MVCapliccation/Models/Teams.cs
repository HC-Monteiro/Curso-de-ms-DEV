using EGamezin.Interface;
using System.Collections.Generic;
using System.IO;

namespace EGamezin.Models
{

                    //Herança      Interface/Contrato
    public class Teams : TeamDataBase, ITeam
    {
        public int teamID { get; set; }
        public string Name { get; set; }
        public string teamLogo { get; set; }

        //Variaveis de dados
        private const string caminhoDB = "DataBase/team.csv";

        public Teams()
        {
            CriarPastaOuArquivo(caminhoDB);
        }


        // criar função para receber o objeto Equipe e retornar no formato csv

        private string Preparar(Teams e)
        {
            return $"{e.Name}; {e.teamID}; {e.teamLogo}";
        }



        public void Criar(Teams newTeam)
        {
            //array de string = na posição 0 temos o retorno de preparar
            string[] equipe_texto = { Preparar(newTeam) };


            //adicionar uma nova linha 
                     //caminho do arquivo, string em formato array
            File.AppendAllLines(caminhoDB, equipe_texto);
        }

        public List<Teams> LerEquipes()
        {
            List<Teams> teamList = new List<Teams>();

            // ler todas as linhas do arquivo e armazena em um array;
            string[] lines = File.ReadAllLines(caminhoDB);

            foreach (string item in lines)
            {
                //1;nome da equipe; caminho da imagem
                string[] teamLine = item.Split(';');
                Teams equipeAtual = new Teams();
                equipeAtual.teamID = int.Parse(teamLine[0]);
                equipeAtual.Name = teamLine[1];
                equipeAtual.teamLogo = (teamLine[2]);

                teamList.Add(equipeAtual);

            }

            return teamList;

        }
    }
}
