namespace MarolateCore.Application.Configuration
{
    public class AppSettings
    {

        public JwtSettings Jwt { get; set; }
        public DatabaseSettings Database { get; set; }
        public SystemSettings System { get; set; }
    }

    public class JwtSettings
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpireMinutes { get; set; }
    }

    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
    }

    public class SystemSettings
    {
        public string EnvironmentName { get; set; }
        public bool MaintenanceMode { get; set; }
    }
}
