using DIExamples.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private EmailService _emailService;
        public MessageController()
        {
            _emailService = new EmailService();
        }

        [HttpPost(Name = "SendMesage")]
        public IActionResult SendMessage(string message)
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
