using System.Collections.Generic;
using EveFramework.Entities.Viewmodels;
using EveFramework.Interfaces;
using EveFramework.Services;
using Umbraco.Web.WebApi;

namespace EveFramework.Controllers.API
{
    public class MapController : UmbracoApiController
    {
        private IMapService _mapService = MapService.Instance;

        public IEnumerable<SolarsystemViewModel> GetSolarsystems()
        {
            return _mapService.GetSolarsystemsList();
        }
    }
}
