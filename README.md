# TwitchVrcAvatarOSC
Twitch bot which allows you to manipulate vrchat avatar thru OSC.

( OSC code from https://github.com/vrchat/OscCore )

# Example config

- ``GlobalDelay/DelayPerUser`` - Have format ``HOURS:MINUTES:SECONDS``

- ``ExecutionDuration`` - Duration is in seconds that means that action will be executed for x amount of seconds and after that default value for that actino will be sended.

- ``NormalAccess`` - Set to false means only that command can be accessed by having sub/moderator/vip perms.

- ``SubPlans`` - NotSst, Prime, Tier1, Tier2, Tier3

Example:

VrcEmote value iss set to 1 for 6 seconds and after that time its set to 0.

```
{
  "OscServerIP": "127.0.0.1",
  "OscServerPort": 9000,
  "TwitchUsername": "twitch-username",
  "TwitchOAuth": "twitch-oauth",
  "ChannelName": "channel-name",
  "CommandPrefix": "!",
  "Events": {
    "OnCommand": {
      "test": {
        "NormalAccess": true,
        "SubAccess": false,
        "SubMonths": 0,
        "ModAccess": false,
        "VipAccess": false,
        "GlobalDelay": "00:00:00",
        "DelayPerUser": "00:00:00",
        "OscOutActions": [
          {
            "ActionName": "/avatar/parameters/VRCEmote",
            "ExecutionDuration": 3,
            "DefaultValue": 0,
            "Value": 1
          }
        ]
      }
    },
    "OnReward": {
      "<REWARD ID>": {
        "NormalAccess": true,
        "SubAccess": false,
        "SubMonths": 0,
        "ModAccess": false,
        "VipAccess": false,
        "GlobalDelay": "00:00:00",
        "DelayPerUser": "00:00:00",
        "OscOutActions": []
      }
    },
    "OnReceiveBits": [
      {
        "MinBits": 100,
        "MaxBits": 1000,
        "NormalAccess": true,
        "SubAccess": false,
        "SubMonths": 0,
        "ModAccess": false,
        "VipAccess": false,
        "GlobalDelay": "00:00:00",
        "DelayPerUser": "00:00:00",
        "OscOutActions": [
          {
            "ActionName": "/avatar/parameters/VRCEmote",
            "ExecutionDuration": 3,
            "DefaultValue": 0,
            "Value": 1
          }
        ]
      }
    ],
    "OnNewSubscriber": [
      {
        "SubPlans": [
          "NotSet"
        ],
        "GlobalDelay": "00:00:00",
        "OscOutActions": [
          {
            "ActionName": "/avatar/parameters/VRCEmote",
            "ExecutionDuration": 3,
            "DefaultValue": 0,
            "Value": 1
          }
        ]
      }
    ],
    "OnReSubscriber": [
      {
        "MinMonths": 0,
        "MaxMonths": 365,
        "SubPlans": [
          "NotSet"
        ],
        "GlobalDelay": "00:00:00",
        "OscOutActions": [
          {
            "ActionName": "/avatar/parameters/VRCEmote",
            "ExecutionDuration": 3,
            "DefaultValue": 0,
            "Value": 1
          }
        ]
      }
    ],
    "OnBeingHosted": [
      {
        "MinViewers": 0,
        "MaxViewers": 1000,
        "GlobalDelay": "00:00:00",
        "OscOutActions": [
          {
            "ActionName": "/avatar/parameters/VRCEmote",
            "ExecutionDuration": 3,
            "DefaultValue": 0,
            "Value": 1
          }
        ]
      }
    ],
    "OnUserBanned": {
      "GlobalDelay": "00:00:00",
      "OscOutActions": [
        {
          "ActionName": "/avatar/parameters/VRCEmote",
          "ExecutionDuration": 3,
          "DefaultValue": 0,
          "Value": 1
        }
      ]
    },
    "OnUserTimedout": {
      "GlobalDelay": "00:00:00",
      "OscOutActions": [
        {
          "ActionName": "/avatar/parameters/VRCEmote",
          "ExecutionDuration": 3,
          "DefaultValue": 0,
          "Value": 1
        }
      ]
    }
  }
}
```
