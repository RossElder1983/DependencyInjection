using DIExamples.DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DIExamples.Controllers.DI
{
    [ApiController]
    [Route("[controller]")]
    public class DIMessageService : ControllerBase
    {
        private readonly ILogger<DIMessageService> _logger;
        private readonly IMessageService _messageService;

        public DIMessageService(ILogger<DIMessageService> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        [HttpPost(Name = "DISendMessage")]
        public IActionResult SendMessage(string message)
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
