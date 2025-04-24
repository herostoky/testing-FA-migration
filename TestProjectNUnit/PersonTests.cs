using TestingByeFA;

namespace TestProjectNUnit
{
    public class PersonTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CelebrateBirthday_ShouldIncrementAge()
        {
            // Arrange
            var person = new Person
            {

            };

            // Act
            person.CelebrateBirthday();

            // Assert
            Assert.AreEqual(32, person.Age);
            StringAssert.Contains("ok", "is this ok ?");
        }
    }
}