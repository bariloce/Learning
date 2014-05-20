using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyWebTest
{
    using Nancy;
    using Nancy.Testing;
    using NancyWeb.Models.Install;
    using NancyWeb.Modules.Install;
    using Xunit;

    public class InstallTests
    {
        [Fact]
        public void ShouldBeAbleToPostData()
        {
            var browser = new Browser(new DefaultNancyBootstrapper());
            
            
            //Act
            var response = browser.Post("/install/testconnection/",
                with =>
                {
                    with.HttpRequest();
                    with.FormValue("SqlServerName", "Marcus");
                    with.FormValue("SqlDatabaseName", "BtmGuy");
                });

            //Assert
            
            Assert.NotEmpty(response.GetModel<InstallModel>().ConnectionString);
        }
    }
}
