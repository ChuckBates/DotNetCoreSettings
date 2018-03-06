namespace DotNetCoreSettings
{
    public class Settings : ISettings
    {
        public Integrations Integrations { get; set; }
        public Credentials Creds { get; set; }
    }

    public class Integrations
    { 
        public Cassandra Cassandra { get; set; }
        public Rabbit Rabbit { get; set; }
    }

    public class Credentials
    {
        public Credential Cassandra { get; set; }
        public Credential Rabbit { get; set; }
    }

    public class Cassandra
    {
        public string HostName { get; set; }
        public string Port { get; set; }
    }

    public class Rabbit
    {
        public Queue Queue { get; set; }
    }

    public class Queue
    {
        public string Exchange { get; set; }
        public string Consumer { get; set; }
    }

    public class Credential
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}