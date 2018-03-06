namespace DotNetCoreSettings
{
    public interface ISettings
    {
        Integrations Integrations { get; set; }
        Credentials Creds { get; set; }
    }
}