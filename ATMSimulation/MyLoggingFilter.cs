using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATMSimulation
{
    // Creating a custom filter
    // • Inherit from ActionFilterAttribute class
    // • Override OnActionExecuting Method
    // • And/or overried OnActionExecuted Method

    // Example: Creating a code to log each successful action
    public class MyLoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var request = filterContext.HttpContext.Request;
            //Logger.logRequest(request.UserHostAddress);
            base.OnActionExecuted(filterContext);
        }
    }

    // Also note OutputCache filter which can cache output for a duration along
    // with having Ids for designating caching differently for different actions
}