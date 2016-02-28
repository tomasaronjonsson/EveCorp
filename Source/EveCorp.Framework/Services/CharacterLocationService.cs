using System.Collections.Generic;
using EveFramework.Entities;
using EveFramework.Entities.DataModels;
using EveFramework.Interfaces;

namespace EveFramework.Services
{
    public class CharacterLocationService : ICharacterLocationService
    {
        private static ICharacterLocationService _instance;

        public static ICharacterLocationService Instance => _instance ?? (_instance = new CharacterLocationService());

        private static  IDatabaseService<CharacterLocationEntryDataModel> _database = new DatabaseService<CharacterLocationEntryDataModel>(Constants.TableCharacterLocationEntry);


        public void NewNentry(CharacterLocationEntryDataModel characterLocationEntry)
        {

            _database.Save(characterLocationEntry);
        }

        public List<CharacterLocationEntryDataModel> GetAllLocationEntries()
        {
            return _database.GetAll();
        }

        public void Delete(CharacterLocationEntryDataModel characterLocationEntry)
        {
            _database.Delete(characterLocationEntry);
        }

    }
}
