using Newtonsoft.Json;

namespace DotNetCoreSettings.Controllers
{
    public class SettingsController
    {
        readonly ISettings settings;

        public SettingsController(ISettings settings)
        {
            this.settings = settings;
        }

        public string Index()
        {
            return JsonConvert.SerializeObject(settings, Formatting.Indented);
        }
    }
}