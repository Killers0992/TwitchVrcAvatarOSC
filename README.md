# TwitchVrcAvatarOSC
Twitch bot which allows you to manipulate vrchat avatar thru OSC.

( OSC code from https://github.com/vrchat/OscCore )

# Example config

GlobalDelay/DelayPerUser is in format HOURS:MINUTES:SECONDS

ExecutionDuration is in seconds that means that action will be executed for x amount of seconds and after that default value for that actino will be sended.

Example:

VrcEmote value iss set to 1 for 6 seconds and after that time its set to 0.

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
