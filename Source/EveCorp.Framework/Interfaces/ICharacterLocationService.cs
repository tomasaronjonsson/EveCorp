using System.Collections.Generic;
using EveFramework.Entities.DataModels;

namespace EveFramework.Interfaces
{
    public interface ICharacterLocationService
    {
        void NewNentry(CharacterLocationEntryDataModel characterLocationEntry);

        List<CharacterLocationEntryDataModel> GetAllLocationEntries();

    }
}
