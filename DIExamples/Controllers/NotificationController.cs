using DIExamples.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        private EmailService _emailService;
        public NotificationController()
        {
            _emailService = new EmailService();
        }

        [HttpPost(Name = "SendNotification")]
        public IActionResult Send(string message)
        {
            try
            {
                var response = _emailService.SendEmail(message);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }            
        }
    }
}
