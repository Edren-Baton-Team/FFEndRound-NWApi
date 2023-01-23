namespace FFEndRound
{
    using MEC;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using System.Collections.Generic;

    public class EventHandlers
    {
        [PluginEvent(ServerEventType.RoundRestart)]
        public void OnRestart()
        {
            Timing.KillCoroutines();
            Server.FriendlyFire = false;
        }
        [PluginEvent(ServerEventType.RoundStart)]
        public void RoundStart() => Timing.RunCoroutine(ServerLoop());

        public IEnumerator<float> ServerLoop()
        {
            for (; ; )
            {
                Log.Debug("Round goes on...");
                if (RoundSummary.singleton._roundEnded)
                {
                    Log.Debug("КОНТАКТ!");
                    Server.SendBroadcast(FFEndRound.Instance.Config.Broadcast, FFEndRound.Instance.Config.BroadcastTime);
                    Server.FriendlyFire = true;
                    yield break;
                }
                yield return Timing.WaitForSeconds(1f);
            }
        }
    }
}
