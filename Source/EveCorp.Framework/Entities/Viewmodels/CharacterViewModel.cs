using System;
using EveFramework.Entities.DataModels;

namespace EveFramework.Entities.Viewmodels
{
    public class CharacterViewModel
    {
        public CharacterViewModel(CharacterLocationEntryDataModel locEntry)
        {
            Name = locEntry.CharacterName;
            ShipTypeName = locEntry.ShipTypeName;
            LastSeen = locEntry.DateTime;
        }
        public string Name { get; set; }
        public string ShipTypeName { get; set; }
        public DateTime LastSeen { get; set; }
    }
}