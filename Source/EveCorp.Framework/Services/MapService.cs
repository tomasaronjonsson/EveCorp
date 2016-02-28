using System;
using System.Collections.Generic;
using System.Linq;
using EveFramework.Entities.Viewmodels;
using EveFramework.Interfaces;
using Umbraco.Core;

namespace EveFramework.Services
{
    public class MapService : IMap
    {

        private ICharacterLocationService _characterLocationService = CharacterLocationService.Instance;
        private static IMap _instance;

        public static IMap Instance => _instance ?? (_instance = new MapService());

        public List<MapSolarsystemViewModel> GetMap()
        {

            var solarmapList = new List<MapSolarsystemViewModel>();

            var locationEntriesPassed2Days =
                _characterLocationService.GetAllLocationEntries()?
                    .OrderByDescending(x => x.DateTime)
                    .Where(x => x.DateTime > DateTime.Now.AddDays(-2))
                    .DistinctBy(x => x.CharacterName);


            if (locationEntriesPassed2Days != null)
                foreach (var locEntry in locationEntriesPassed2Days)
                {

                    var currentSystem = solarmapList.FirstOrDefault(x => x.Name == locEntry.SolarSystemName);

                    if (currentSystem == null)
                    {
                        currentSystem = new MapSolarsystemViewModel
                        {
                            Name = locEntry.SolarSystemName,
                            CreateDateTime = DateTime.Now,
                            Characters = new List<CharacterViewModel>()
                            
                        };
                        solarmapList.Add(currentSystem);

                    }



                    currentSystem.Characters.Add(new CharacterViewModel
                    {
                        Name = locEntry.CharacterName,
                        ShipTypeName = locEntry.ShipTypeName,
                        LastSeen = locEntry.DateTime
                    });


                }
            return solarmapList;
        }
    }
}
