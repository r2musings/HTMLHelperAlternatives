using HtmlHelperReplacement.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace HtmlHelperReplacement
{
    public static class HtmlHelpers
    {
        public static string GetCleanString(this IHtmlHelper helper, string key)
        {
            IServiceProvider services = helper.ViewContext.HttpContext.RequestServices;

            ICleaningService cleaningService = (ICleaningService)services.GetService(typeof(ICleaningService));

            return cleaningService.GetCleanString(key);
        }
    }
}
