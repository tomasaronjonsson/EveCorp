
using System;
using System.Web.Mvc;
using EveFramework.Entities.DataModels;
using EveFramework.Services;

namespace EveFramework.Controllers.API
{
    public class CharacterLocationController : Controller
    {

        [HttpGet]
        public ActionResult UpdateLocation()
        {

            if (!string.IsNullOrEmpty(Request.ServerVariables.Get("HEADER_EVE_CHARNAME")))
            {

                var characterLocationEntry = new CharacterLocationEntryDataModel
                {
                    CharacterName = Request.ServerVariables.Get("HEADER_EVE_CHARNAME"),
                    DateTime = DateTime.Now,
                    ShipTypeName = Request.ServerVariables.Get("HTTP_EVE_SHIPTYPENAME"),
                    SolarSystemName = Request.ServerVariables.Get("HTTP_EVE_SOLARSYSTEMNAME")

                };

                CharacterLocationService.Instance.NewNentry(characterLocationEntry);
                return Json(characterLocationEntry, JsonRequestBehavior.AllowGet);

            }

            return null;
        }
    }
}
