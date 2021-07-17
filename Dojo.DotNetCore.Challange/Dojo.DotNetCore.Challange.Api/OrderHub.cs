using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Dojo.DotNetCore.Challange.Api
{
    public class OrderHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}