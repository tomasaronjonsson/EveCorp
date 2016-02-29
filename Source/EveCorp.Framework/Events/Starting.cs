using System.Web.Mvc;
using System.Web.Routing;
using EveFramework.Entities.DataModels;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence;

namespace EveFramework.Events
{
    public class Starting : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            //setting up the database
            var logger = LoggerResolver.Current.Logger;
            var dbContext = ApplicationContext.Current.DatabaseContext;
            var helper = new DatabaseSchemaHelper(dbContext.Database, logger, dbContext.SqlSyntax);
            helper.CreateTable<CharacterLocationEntryDataModel>(false);


            RouteTable.Routes.MapRoute(
           "CharacterLocation",
           "CharacterLocation/{action}/",
           new
           {
               controller = "CharacterLocation",
               action = "UpdateLocation",
           });

        }
    }
}
