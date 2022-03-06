# TwitchVrcAvatarOSC
Twitch bot which allows you to manipulate vrchat avatar thru OSC.

Currently implemented events:
- Commands
- OnReSubscribe / OnSubscribe
- OnBanned / OnTimedout
- OnUseReward
- OnReceiveBits
- OnBeingHosted
- OnFollow

# Download

[Link](https://github.com/Killers0992/TwitchVrcAvatarOSC/releases/latest)



# Contact

[![Discord Banner](https://discordapp.com/api/guilds/948581245527425114/widget.png?style=banner3)](https://discord.gg/uhvsaEFmSE)

# Some information

- If you want easily get REWARD IDS just redeem something via points and in console check for

``[LOG] [TwitchReward] User USERNAME executed reward REWARD_ID but that reward id is not added in config!``

- Possible parameters for your avatar which can be used in OCS can be found in 

``LocalLow/VRChat/VRChat/OCS/<userid>/<avatarid>.json``

https://docs.vrchat.com/v2022.1.1/docs/osc-avatar-parameters

https://docs.vrchat.com/v2022.1.1/docs/osc-as-input-controller#supported-inputs


Config values:

- ``GlobalDelay/DelayPerUser`` - Have format ``HOURS:MINUTES:SECONDS``

- ``ExecutionDuration`` - Duration is in seconds that means that action will be executed for x amount of seconds and after that default value for that actino will be sended.

- ``NormalAccess`` - Set to false means only that command can be accessed by having sub/moderator/vip perms.

- ``SubPlans`` - NotSst, Prime, Tier1, Tier2, Tier3

- ``ExecuteRandomAction`` - Can be used only if OscOutActions have more than 1 element.

- ``Value`` cant be null in OscOutActions but can have values like true/false (bool), 0/1 (integer), 0.1/0.0 (float)

- ``DefaultValue`` if its null then after x seconds of execution duration is not doing anything. ( values can be same as in ``Value`` ) 

Some samples:

```
{
  "ActionName": "/avatar/parameters/VRCEmote",
  "ExecutionDuration": 0,
  "DefaultValue": null,
  "Value": 3
}
```

- That in config means ``VRCEmote`` expressions menu parameter will have value set to ``3``.


```
{
  "ActionName": "/avatar/parameters/VRCEmote",
  "ExecutionDuration": 3,
  "DefaultValue": 0,
  "Value": 1
}
```

- That in config means ``VRCEmote`` expressions menu parameter will have value set to ``1`` and after ``3`` seconds value wil be set to ``0``.


# Default config

```
{
  "OscServerIP": "127.0.0.1",
  "OscServerPort": 9000,
  "TwitchUsername": "twitch-username",
  "TwitchOAuth": "twitch-oauth",
  "ChannelName": "channel-name",
  "ChannelID": "channel-id",
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
    },
    "OnFollow": {
      "GlobalDelay": "00:00:00",
      "ExecuteRandomAction": false,
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

# Empty Config


```
{
  "OscServerIP": "127.0.0.1",
  "OscServerPort": 9000,
  "TwitchUsername": "twitch-username",
  "TwitchOAuth": "twitch-oauth",
  "ChannelName": "channel-name",
  "ChannelID": "channel-id",
  "CommandPrefix": "!",
  "Events": {
    "OnCommand": {},
    "OnReward": {},
    "OnReceiveBits": [],
    "OnNewSubscriber": [],
    "OnReSubscriber": [],
    "OnBeingHosted": [],
    "OnUserBanned": {},
    "OnUserTimedout": {},
    "OnFollow": {}
  }
}
```

