using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDT.Web
{
    public static class SelectItem
    {
        public static HtmlString IsSelected(this IHtmlHelper html, string controllers = "", string actions = "", string cssClass = "active")
        {
            
            //ViewContext viewContext = html.ViewContext;
            //bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            //if (isChildAction)
            //    viewContext = html.ViewContext.ParentActionViewContext;

            //RouteValueDictionary routeValues = viewContext.RouteData.Values;
            //string currentAction = routeValues["action"].ToString();
            //string currentController = routeValues["controller"].ToString();

            //if (string.IsNullOrEmpty(actions))
            //    actions = currentAction;

            //if (string.IsNullOrEmpty(controllers))
            //    controllers = currentController;

            //string[] acceptedActions = actions.Trim().Split(',').Distinct().ToArray();
            //string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            //return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
            //    cssClass : string.Empty;
            return new HtmlString("");
        }
    }
}
