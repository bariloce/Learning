namespace NancyWeb.Models.Install
{
    public class InstallModel
    {
        public string ConnectionString { get; set; }
        public string SqlServerName { get; set; }
        public string SqlDatabaseName { get; set; }
        public string SqlServerUsername { get; set; }
        public string SqlServerPassword { get; set; }
        public bool TrustedConnection { get; set; }
        public bool SqlServerCreateDatabase { get; set; }

        public string TestConnectionMessage { get; set; }
        public bool ConnectionSuccessfull { get; set; }
    }
}