using Dojo.DotNetCore.Challange.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dojo.DotNetCore.Challange.Api.Controllers
{
    public class OrderController : Controller
    {
        private readonly IHubContext<OrderHub> _streaming;

        public OrderController(IHubContext<OrderHub> streaming)
        {
            _streaming = streaming;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody] Order order)
        {
            if (order == null)
                return BadRequest();

            await WriteOnStream(order);

            return order;
        }

        private async Task WriteOnStream(Order data)
        {
            string jsonData = string.Format("{0}\n", JsonSerializer.Serialize(data));

            await _streaming.Clients.All.SendAsync("ReceiveMessage", jsonData);
        }
    }
}