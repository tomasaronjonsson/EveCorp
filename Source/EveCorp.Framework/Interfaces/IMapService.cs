using System.Collections.Generic;
using EveFramework.Entities.Viewmodels;

namespace EveFramework.Interfaces
{
    public interface IMapService
    {
        List<SolarsystemViewModel> GetSolarsystemsList();
    }
}
