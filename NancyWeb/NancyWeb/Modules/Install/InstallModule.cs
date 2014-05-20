using Nancy;
using NancyWeb.Models.Install;
using Nancy.ModelBinding;
using System.Data.SqlClient;
using System.Diagnostics;

namespace NancyWeb.Modules.Install
{
    using System;

    public class InstallModule : NancyModule
    {
        public InstallModule()
        {
            Get["/install"] = _ =>
            {
                var model = new InstallModel();
                return View[model];
            };

            Post["/install"] = _ =>
            {
                var model = this.Bind<InstallModel>();
                try
                {
                    model.ConnectionString = this.CreateConnectionString(model.TrustedConnection, model.SqlServerName, "tempdb", model.SqlServerUsername, model.SqlServerPassword);
                    Debug.WriteLine(model.ConnectionString);
                    using (var connection = new SqlConnection(model.ConnectionString))
                    {
                        connection.Open();
                    }
                    model.ConnectionSuccessfull = true;
                    model.TestConnectionMessage = "Connection to SQL server was successfully established";
                }
                catch(Exception ex)
                {
                    model.ConnectionSuccessfull = false;
                    model.TestConnectionMessage = "Not possible to connect on SQL server: " + ex.Message;
                }
                return View["Install", model];
            };
        }


        protected string CreateConnectionString(bool trustedConnection, string serverName, string databaseName, string username, string password, int timeout = 0)
        {
            var builder = new SqlConnectionStringBuilder { IntegratedSecurity = trustedConnection, DataSource = serverName, InitialCatalog = databaseName };
            if (!trustedConnection)
            {
                builder.UserID = username;
                builder.Password = password;
            }
            builder.PersistSecurityInfo = false;
            builder.MultipleActiveResultSets = true;
            if (timeout > 0)
            {
                builder.ConnectTimeout = timeout;
            }
            return builder.ConnectionString;
        }
    }
}