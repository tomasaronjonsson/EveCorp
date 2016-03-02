using System.Collections.Generic;
using EveFramework.Entities.DataModels;
using EveFramework.Entities.Viewmodels;

namespace EveFramework.Interfaces
{
    public interface IMapService
    {
        List<SolarsystemViewModel> GetSolarsystemsList();

        //void NewEntry(CharacterLocationEntryDataModel )

    }
}
