namespace FFEndRound
{
    using System.ComponentModel;
    public class Config
    {
        [Description("Plugin Enabled? (Default: true)")]
        public bool IsEnabled { get; set; } = true;
        [Description("Text at the end of the round (Default: <color=red>FF</color> <color=green>ON</color>!)")]
        public string Broadcast { get; set; } = "<color=red>FF</color> <color=green>ON</color>!";
        [Description("What is the duration of the broadcast above? (Default: 30)")]
        public ushort BroadcastTime { get; set; } = 30;
    }
}
