using Nancy;
using nancytest.Objects;
using Nancy.ModelBinding;

namespace HelloWorld
{

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => View["index.html"];

            Post["/post_page"] = _ => {
              var formPage = this.Bind<FormVariables>();
              return View["postpage.html", formPage];
            };
        }
    }
}
