namespace DIExamples.Services
{
    public class EmailService
    {
        public string SendEmail(string message)
        {
            return $"Sending email: {message}";
        }
    }
}
