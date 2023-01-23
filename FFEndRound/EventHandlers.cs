namespace FFEndRound
{
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    public class EventHandlers
    {
        [PluginEvent(ServerEventType.RoundEnd)]
        void OnRoundEnded(RoundSummary.LeadingTeam leadingTeam)
        {
            Server.SendBroadcast(FFEndRound.Instance.Config.Broadcast, FFEndRound.Instance.Config.BroadcastTime);
            Server.FriendlyFire = true;
        }
        [PluginEvent(ServerEventType.RoundRestart)]
        public void OnRestart()
        {
            Server.FriendlyFire = false;
        }
    }
}
