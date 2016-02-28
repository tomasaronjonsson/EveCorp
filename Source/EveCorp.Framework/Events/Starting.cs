using EveFramework.Entities.DataModels;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence;
using Constants = EveFramework.Entities.Constants;

namespace EveFramework.Events
{
    public class Starting : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            //checking for databases
            var logger = LoggerResolver.Current.Logger;
            var dbContext = ApplicationContext.Current.DatabaseContext;
            var helper = new DatabaseSchemaHelper(dbContext.Database, logger, dbContext.SqlSyntax);
            helper.CreateTable<CharacterLocationEntryDataModel>(true);


        }
    }
}
