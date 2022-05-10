using EGamezin.Models;
using System.Collections.Generic;

namespace EGamezin.Interface
{
    public interface ITeam
    {
        //Contrato, representa os metodos obrigatorios em uma classe
        void Criar(Teams newTeam);
        List<Teams> LerEquipes();

    }
}
