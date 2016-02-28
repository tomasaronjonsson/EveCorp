using System.Security.AccessControl;

namespace EveFramework.Entities.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CharacterLocationEntry 
    {

        public string SolarSystemName { get; set; }
        public string PreviousSolarSystemName { get; set; }
        public string CharId { get; set; }
        public DateTime DateTime { get; set; }
        public string ShipTypeId { get; set; }
    }

    
}