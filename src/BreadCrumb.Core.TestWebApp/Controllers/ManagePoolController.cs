using Microsoft.AspNetCore.Mvc;

namespace BreadCrumb.Core.TestWebApp.Controllers
{
    [BreadCrumb(Title = "Pool Manager", Order = 0, UseDefaultRouteUrl = true, IgnoreAjaxRequests = true)]
    public class ManagePoolController : Controller
    {
        [BreadCrumb(Title = "List of pool", Order = 1, IgnoreAjaxRequests = true)]
        public IActionResult NotIndex() // it's a default action here
        {
            return View();
        }

        [BreadCrumb(Title = "Create a pool", Order = 1, IgnoreAjaxRequests = true)]
        public IActionResult Create()
        {
            return View();
        }
    }
}