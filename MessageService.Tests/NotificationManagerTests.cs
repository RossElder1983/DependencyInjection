using DIExamples.Controllers;
using DIExamples.DependencyInjection.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace MessageService.Tests
{
    public class NotificationManagerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Notify_ShouldSendMessage()
        {
            // Arrange
            var mockMessageService = new Mock<IMessageService>();
            var mockLogger = new Mock<ILogger<DINotificationController>>();
            var notificationManager = new DINotificationController(mockLogger.Object, mockMessageService.Object);

            // Act
            notificationManager.SendNotification("Test Message");

            // Assert
            mockMessageService.Verify(x => x.Send("Test Message"), Times.Once);
            Assert.Pass();
        }
    }
}