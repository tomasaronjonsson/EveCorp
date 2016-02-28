using System;
using System.Collections.Generic;

namespace EveFramework.Entities.Viewmodels
{
    public class MapSolarsystemViewModel
    {
        public string Name { get; set; }

        public List<CharacterViewModel> Characters { get; set; }

        public double LocationString { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
