using System;
using System.Collections.Generic;
using System.Linq;
using EveFramework.Entities.Viewmodels;
using EveFramework.Interfaces;
using Umbraco.Core;

namespace EveFramework.Services
{
    public class MapService : IMapService
    {

        private ICharacterLocationService _characterLocationService = CharacterLocationService.Instance;
        private static IMapService _instance;

        public static IMapService Instance => _instance ?? (_instance = new MapService());

        public List<SolarsystemViewModel> GetSolarsystemsList()
        {

            var solarmapList = new List<SolarsystemViewModel>();

            //start by getting a list of solarstystems
            var locationToCreateSolarSystems =
                _characterLocationService.GetAllLocationEntries()?
                    .OrderByDescending(x => x.DateTime)
                    .DistinctBy(x => x.SolarSystemName);

            //than a list of characters
            //todo nota adddays -1 eins og er, ætti að vera bara mínuta, en var að koma tómt ef ég gerði það,
            var currentCharactersLocation =
             _characterLocationService.GetAllLocationEntries()?
                 .OrderByDescending(x => x.DateTime)
                 .Where(x => x.DateTime > DateTime.Now.AddDays(-1))
                 .DistinctBy(x => x.CharacterName);


            if (locationToCreateSolarSystems != null)
                foreach (var locEntry in locationToCreateSolarSystems)
                {

                    var currentSystem = solarmapList.FirstOrDefault(x => x.Name == locEntry.SolarSystemName);

                    if (currentSystem == null)
                    {
                        currentSystem = new SolarsystemViewModel(locEntry);
                  
                        solarmapList.Add(currentSystem);

                    }
                    foreach (var character in currentCharactersLocation.Where(x => x.SolarSystemName == currentSystem.Name))
                    {
                        currentSystem.Characters.Add(new CharacterViewModel(character));
                    }

                }

            return solarmapList;
        }
    }
}
