using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Projet.Filters
{
    public class LogActionFilter: ActionFilterAttribute
    {
            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                Log("OnActionExecuted", filterContext.RouteData);
            }
            private void Log(string methodName, RouteData routeData)
            {
                var controllerName = routeData.Values["controller"];
                var actionName = routeData.Values["action"];
                var message = String.Format("{0} controller:{1} action:{2}", methodName, controllerName, actionName);
                var date = DateTime.Now.ToString("T");
                Debug.WriteLine(message, "Logs de passage d'un utilisateur sur la page Home à " + date);
            }
        }

    }
