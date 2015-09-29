using Nancy;
using nancytest.Objects;
using Nancy.ModelBinding;
using System;
using System.IO;

namespace HelloWorld
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.html"];

            Get["/greeting_card_form"] = _ => View["greetingcardform.html"];

            Post["/post_page"] = _ => {
              var formsubmission = new FormVariables {
                Sender = Request.Form["person1"],
                Recipient = Request.Form["person2"]
              };
              var formPage = this.BindTo(formsubmission);
              return View["postpage.html", formPage];
            };
        }
    }
}
