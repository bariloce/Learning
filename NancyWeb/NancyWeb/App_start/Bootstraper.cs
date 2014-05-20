using Nancy;
using Nancy.Conventions;

namespace NancyWeb.App_start
{
    public class Bootstraper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/scripts", "Scripts"));
        }
    }
}