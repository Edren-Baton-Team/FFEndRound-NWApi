namespace InfinityAmmo
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    public class EventHandlers
    {
        [PluginEvent(ServerEventType.RoundEnd)]
        public void OnRoundEnded(RoundSummary.LeadingTeam leadingTeam)
        {
            Server.SendBroadcast(FFEndRound.FFEndRound.Instance.Config.Broadcast, 30);
            Server.FriendlyFire = true;
        }
        [PluginEvent(ServerEventType.RoundStart)]
        public void OnRoundStart()
        {
            Server.FriendlyFire = false;
        }
    }
}
