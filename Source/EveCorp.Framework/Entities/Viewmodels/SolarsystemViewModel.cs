using System;
using System.Collections.Generic;
using EveFramework.Entities.DataModels;

namespace EveFramework.Entities.Viewmodels
{
    public class SolarsystemViewModel
    {

        public SolarsystemViewModel(CharacterLocationEntryDataModel locEntry)
        {
            Name = locEntry.SolarSystemName;
            Characters = new List<CharacterViewModel>();
            CreateDateTime = locEntry.DateTime;
        }
        public string Name { get; set; }

        public List<CharacterViewModel> Characters { get; set; }

        public double Y { get; set; }
        public double X { get; set; }

        public DateTime CreateDateTime { get; set; }
    }
}
