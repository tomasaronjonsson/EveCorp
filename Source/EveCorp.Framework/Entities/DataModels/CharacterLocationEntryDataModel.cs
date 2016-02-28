using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace EveFramework.Entities.DataModels
{
    using System;

   [TableName(Constants.TableCharacterLocationEntry)]
    [PrimaryKey("Id", autoIncrement = true)]
    public class CharacterLocationEntryDataModel : BaseDataModel
    {

        [PrimaryKeyColumn(AutoIncrement = true)]
        public override int Id { get; set; }

        public string SolarSystemName { get; set; }
        public string CharacterName { get; set; }
        public DateTime DateTime { get; set; }
        public string ShipTypeName { get; set; }


       public override string ToString()
       {
           return CharacterName;
       }
    }


}