namespace FFEndRound
{
    using System.ComponentModel;
    public class Config
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;
        public string Broadcast { get; set; } = "<color=red>FF</color> <color=green>ON</color>!";
    }
}
