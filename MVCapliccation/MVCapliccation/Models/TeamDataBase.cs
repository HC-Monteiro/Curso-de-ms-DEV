using System.IO;

namespace EGamezin.Models
{
    public class TeamDataBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            string pasta = caminho.Split('/')[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            
            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }


        }
    }
}
