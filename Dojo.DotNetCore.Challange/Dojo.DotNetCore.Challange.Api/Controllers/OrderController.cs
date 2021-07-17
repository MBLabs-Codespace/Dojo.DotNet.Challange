using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult Index()
        {
            return View();
        }
    }
}