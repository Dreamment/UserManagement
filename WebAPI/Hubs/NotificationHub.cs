using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace WebAPI.Hubs
{
    [Authorize]
    public class NotificationHub : Hub
    {
        public async override Task OnConnectedAsync()
        {
            Thread.Sleep(1000);
            try
            {
                var claim = Context.User?.FindFirst(ClaimTypes.Role)?.Value;
                var name = Context.User?.FindFirst(ClaimTypes.Name)?.Value;
                await Groups.AddToGroupAsync(Context.ConnectionId, $"{claim}");
                await Clients.Caller.SendAsync("Connected", $"You are connected as {name} and your role is {claim}");
            }
            catch (Exception ex)
            {
                await Clients.Caller.SendAsync("Error", ex.Message);
            }
        }

    }
}
