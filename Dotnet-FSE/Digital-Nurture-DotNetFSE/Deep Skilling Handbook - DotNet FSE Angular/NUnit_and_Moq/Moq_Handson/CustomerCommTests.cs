using NUnit.Framework;
using Moq;

namespace Moq_Handson
{
    // 1. Define the Interface
    public interface IMailSender
    {
        bool SendMail(string toAddress, string message);
    }

    // 2. Class Under Test (with Constructor Injection)
    public class CustomerComm
    {
        IMailSender _mailSender;
        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public bool SendMailToCustomer()
        {
            _mailSender.SendMail("cust123@abc.com", "Some Message");
            return true;
        }
    }

    // 3. The NUnit/Moq Test Class
    [TestFixture]
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            // Arrange: Create a mock of the interface
            var mockMailSender = new Mock<IMailSender>();
            
            // Configure the mock to return true whenever SendMail is called
            mockMailSender.Setup(m => m.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            
            // Inject the mock object into the class
            var customerComm = new CustomerComm(mockMailSender.Object);

            // Act
            bool result = customerComm.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.True);
        }
    }
}