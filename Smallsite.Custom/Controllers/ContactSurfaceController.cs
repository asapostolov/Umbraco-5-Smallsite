using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Cms.Web.Surface;
using System.Web.Mvc;

namespace Smallsite.Custom
{
    /// <summary>
    /// Surfase controller for Contact form
    /// </summary>
    public class ContactSurfaceController : SurfaceController
    {
        [ChildActionOnly]
        public PartialViewResult ContactForm()
        {
            var model = new ContactModel();
            return PartialView(model);
        }

        [HttpPost]
        public ActionResult SendContactInfo(
            [Bind(Prefix = "contactForm")]
            ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }


            //return new JavaScriptResult() { Script="alert('Your message is sent! We will contact you for more information.')"};
            //return new RedirectResult("/");
            return new JsonResult() { Data = new { Name = "Sucess!" } };
        }
    }
}
