namespace HelloWorld
{
    using Microsoft.AspNet.Builder;
    using Nancy.Owin;
    using Nancy;

    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseOwin(x => x.UseNancy());
        }
    }
    public class CustomRootPathProvider : IRootPathProvider
    {
        public string GetRootPath()
        {
            return "/Users/jillkuchman/Documents/csharp-samples/nancy/helloworldnancy";
        }
    }
}
