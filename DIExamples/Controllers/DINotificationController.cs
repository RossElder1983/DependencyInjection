using DIExamples.DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DINotificationController : ControllerBase
    {
        private readonly ILogger<DINotificationController> _logger;
        private readonly IMessageService _messageService;

        public DINotificationController(ILogger<DINotificationController> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        [HttpPost(Name = "DISendNotification")]
        public IActionResult SendNotification(string message)
        {
            try
            {
                var response = _messageService.Send(message);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
