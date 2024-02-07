using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared_Class_Vivo_Apps.Models;
using System;

namespace Vivo_Apps_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost("trigger")]
        public IActionResult WebhookTrigger([FromBody] Option<int> payload)
        {
            try
            {
                // Your webhook logic goes here
                _logger.LogInformation("Webhook triggered with payload: {payload}", payload.Text);

                // Optionally, you can perform additional processing or respond with a specific message

                // You can use the notificationUrl parameter here as needed

                return Ok("Webhook triggered successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the webhook");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
