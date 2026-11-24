using Oxide.Core;
using UnityEngine;

namespace Oxide.Plugins;

[Info("MySteamID-Rust", "LogicOutpost", "1.0.0")]
public class MySteamID : RustPlugin
{
    [ChatCommand("steamid")] 
    private void SteamIdCommand(BasePlayer player)
    {
        SendReply(player, $"Your steam ID is: {player.UserIDString}");
    }
}