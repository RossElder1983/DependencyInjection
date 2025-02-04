using DIExamples.DependencyInjection.Interfaces;

namespace DIExamples.DependencyInjection.Concrete
{
    public class EmailService : IMessageService
    {
        public string Send(string message)
        {
            return $"Sending email: {message}";
        }
    }
}
