using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // These are action methods

        public ActionResult Index__()
        {
            return View();
        }
        // render the default View for the Action Index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewResult homePage = View();
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            // Invoking the constructor of the class Controller
            // return View();
            return homePage;

        }

        public string Index_()
        {
            return "Hello World";
        }

        // GET is used to request data from a specified resource.
        
        // using Attributes
        // This means the method responds to HTTP GET (added the HttpGet attribute)
        [HttpGet]
        public ViewResult RsvpForm()
        {
            // don't forget to add the associated View (Right click  ...)
            ViewResult rsvpForm = View();
            return rsvpForm;
        }

        // POST is used to send data to a server to create/update a resource.
        // Notice the Model Binding feature
        // The GuestResponse object that is passed as the parameter to the action method is automatically populated with the data from the form fields.
        // This process is the opposite of using the HTML helper methods
        // the names of the input elements are used to set the values of the properties in an instance of the model class, 
        // which is then passed to the POST-enabled action method

        // Ask MVC to find and render a view called Thanks and to pass the GuestResponse object to the view.

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
        // don't forget to add the associated View again (Right click  ...)

        // Summary:
            //     Gets the model state dictionary object that contains the state of the model and
            //     of model-binding validation.
            //
            // Returns:
            //     The model state dictionary.

            // ModelState object is available because of Model Binding

            if (ModelState.IsValid)
            {
                // TODO: Send Email response to the party organizer 
                return View("Thanks", guestResponse);
            }
            else 
            {
                // there is a validation error
                return View();
            }

            
        }


    }
}