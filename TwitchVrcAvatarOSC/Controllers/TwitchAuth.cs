using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TwitchVrcAvatarOSC.Controllers
{
    public class TwitchAuth : Controller
    {
        [HttpGet("~/twitch/link")]
        public async Task<IActionResult> TwitchLink()
        {
            string redirect_uri = "http://localhost:3000/twitch/response";
            string response_type = "token";
            string scopes = "chat:read+channel:read:redemptions+channel:read:subscriptions";

            return Redirect($"https://id.twitch.tv/oauth2/authorize?client_id={TwitchBot.ClientID}&redirect_uri={redirect_uri}&response_type={response_type}&scope={scopes}");
        }

        [HttpGet("~/twitch/response")]
        public async Task<IActionResult> TwitchResponse()
        {
            return View();
        }
    }
}
