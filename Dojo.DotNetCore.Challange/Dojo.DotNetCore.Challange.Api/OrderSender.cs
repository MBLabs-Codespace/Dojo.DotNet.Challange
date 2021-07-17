using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Dojo.DotNetCore.Challange.Api
{
    public class OrderSender : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}