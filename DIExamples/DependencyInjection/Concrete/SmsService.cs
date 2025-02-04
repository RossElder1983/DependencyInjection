using DIExamples.DependencyInjection.Interfaces;

namespace DIExamples.DependencyInjection.Concrete
{
    public class SmsService : IMessageService
    {
        public string Send(string message)
        {
            return $"Sending SMS: {message}";
        }
    }
}
