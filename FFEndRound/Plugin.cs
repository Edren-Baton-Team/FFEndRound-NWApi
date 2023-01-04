using InfinityAmmo;
using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace FFEndRound
{
    public class FFEndRound
    {
        public const string Name = "FFEndRound";
        public const string Version = "v1.0.1";
        public const string Author = "Rysik5318";
        public static FFEndRound Instance { get; private set; }
        [PluginConfig("config.yml")]
        public Config Config;
        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint(Name, Version, "FFEndRound!", Author)]
        void LoadPlugin()
        {
            if (!Config.IsEnabled)
                return;
            Instance = this;
            EventManager.RegisterEvents<EventHandlers>(this);
            Log.Raw($"<color=blue>Loading {Name} {Version} by {Author}</color>");
            var handler = PluginHandler.Get(this);
            handler.SaveConfig(this, nameof(Config));
        }
    }
}
