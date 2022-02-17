# TwitchVrcAvatarOSC
Twitch bot which allows you to manipulate vrchat avatar thru OSC.

( OSC code from https://github.com/vrchat/OscCore )

# Example config
```
{
  "TwitchUsername": "Killers0992",
  "TwitchOAuth": "<token>",
  "ChannelName": "Killers0992",
  "SlashCommands": {
    "test": {
      "NormalAccess": true,
      "SubAccess": false,
      "ModAccess": false,
      "VipAccess": false,
      "GlobalDelay": "00:00:00",
      "DelayPerUser": "00:00:00",
      "OscOutActions": [
        {
          "ActionName": "/avatar/parameters/VRCEmote",
          "ExecutionDuration": 6,
          "DefaultValue": 0,
          "Value": 1
        }
      ]
    }
  }
}
```
