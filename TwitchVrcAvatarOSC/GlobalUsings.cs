global using System;
global using System.IO;
global using System.Linq;
global using System.Net;
global using System.Net.Http;
global using System.Net.Sockets;
global using System.Threading;
global using System.Threading.Tasks;
global using System.Diagnostics;
global using System.Collections.Generic;
global using System.Collections.Concurrent;

global using TwitchVrcAvatarOSC;
global using TwitchVrcAvatarOSC.Bot;
global using TwitchVrcAvatarOSC.Models;
global using TwitchVrcAvatarOSC.Services;
global using TwitchVrcAvatarOSC.Properties;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.DependencyInjection;

global using TwitchLib.Api;
global using TwitchLib.PubSub;
global using TwitchLib.Client;
global using TwitchLib.Client.Models;
global using TwitchLib.Communication.Clients;
global using TwitchLib.Communication.Models;
global using TwitchLib.PubSub.Enums;

global using Newtonsoft.Json;

