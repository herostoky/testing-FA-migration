using FluentAssertions;
using Shouldly;
using TestingByeFA;

namespace TestProjectXUnit
{
    public class PersonTests
    {
        [Fact]
        public void CelebrateBirthday_ShouldIncrementAge()
        {
            // Arrange
            var person = new Person(31, null, null);

            // Act
            person.CelebrateBirthday();

            // Assert
            Assert.Equal(32, person.Age);
        }

        // result.Should().Be(expected)
        [Fact]
        public void Name_Should_Be_Expected()
        {
            var person = new Person(30, "John", null);
            // person.Name.Should().Be("John");
            person.Name.ShouldBe("John");
        }

        // result.Should().NotBe(unexpected)
        [Fact]
        public void Name_Should_NotBe_Unexpected()
        {
            var person = new Person(30, "John", null);
            person.Name.Should().NotBe("Jane");
        }

        // result.Should().BeNull()
        [Fact]
        public void Address_Should_BeNull()
        {
            var person = new Person();
            person.Address.Should().BeNull();
        }

        // result.Should().NotBeNull()
        [Fact]
        public void Address_Should_NotBeNull()
        {
            var person = new Person(30, "John", new Address());
            person.Address.Should().NotBeNull();
        }

        // result.Should().BeTrue()
        [Fact]
        public void IsAdult_Should_BeTrue_When_Age_Is_18()
        {
            var person = new Person(18, "John", null);
            person.IsAdult().Should().BeTrue();
        }

        // result.Should().BeFalse()
        [Fact]
        public void IsAdult_Should_BeFalse_When_Age_Is_17()
        {
            var person = new Person(17, "John", null);
            person.IsAdult().Should().BeFalse();
        }

        // result.Should().BeSameAs(expected)
        [Fact]
        public void Address_Should_BeSameAs_Reference()
        {
            var address = new Address();
            var person = new Person(30, "John", address);
            person.Address.Should().BeSameAs(address);
        }

        // result.Should().NotBeSameAs(unexpected)
        [Fact]
        public void Address_Should_NotBeSameAs_NewReference()
        {
            var person = new Person(30, "John", new Address());
            var differentAddress = new Address();
            person.Address.Should().NotBeSameAs(differentAddress);
        }

        // result.Should().BeOfType<T>()
        [Fact]
        public void Age_Should_BeOfType_Int()
        {
            var person = new Person(30, "John", null);
            person.Age.Should().BeOfType(typeof(int));
        }

        // result.Should().NotBeOfType<T>()
        [Fact]
        public void Age_Should_NotBeOfType_String()
        {
            var person = new Person(30, "John", null);
            person.Age.Should().NotBeOfType(typeof(string));
        }

        // result.Should().BeGreaterThan(value)
        [Fact]
        public void Age_Should_BeGreaterThan_18()
        {
            var person = new Person(25, "John", null);
            person.Age.Should().BeGreaterThan(18);
        }

        // result.Should().BeGreaterThanOrEqualTo(value)
        [Fact]
        public void Age_Should_BeGreaterThanOrEqualTo_18()
        {
            var person = new Person(18, "John", null);
            person.Age.Should().BeGreaterThanOrEqualTo(18);
        }

        // result.Should().BeLessThan(value)
        [Fact]
        public void Age_Should_BeLessThan_100()
        {
            var person = new Person(99, "John", null);
            person.Age.Should().BeLessThan(100);
        }

        // result.Should().BeLessThanOrEqualTo(value)
        [Fact]
        public void Age_Should_BeLessThanOrEqualTo_40()
        {
            var person = new Person(40, "John", null);
            person.Age.Should().BeLessThanOrEqualTo(40);
        }

        // result.Should().BePositive()
        [Fact]
        public void Age_Should_BePositive()
        {
            var person = new Person(1, "John", null);
            person.Age.Should().BePositive();
        }

        // result.Should().BeNegative()
        [Fact]
        public void Temperature_Should_BeNegative()
        {
            const int temperature = -5;
            temperature.Should().BeNegative();
        }

        // result.Should().BeInRange(low, high)
        [Fact]
        public void Age_Should_BeInRange()
        {
            var person = new Person(25, "John", null);
            person.Age.Should().BeInRange(18, 30);
        }

        // result.Should().NotBeInRange(low, high)
        [Fact]
        public void Age_Should_NotBeInRange()
        {
            var person = new Person(17, "John", null);
            person.Age.Should().NotBeInRange(18, 30);
        }

        // collection.Should().Contain(item)
        [Fact]
        public void Names_Collection_Should_Contain_Item()
        {
            var names = new[] { "Alice", "Bob" };
            names.Should().Contain("Alice");
        }

        // collection.Should().NotContain(item)
        [Fact]
        public void Names_Collection_Should_NotContain_Item()
        {
            var names = new[] { "Alice", "Bob" };
            names.Should().NotContain("Charlie");
        }

        // collection.Should().BeEmpty()
        [Fact]
        public void Names_Collection_Should_BeEmpty()
        {
            var names = new List<string>();
            names.Should().BeEmpty();

            names.Add("Alice");
            names.Should().NotBeEmpty();
        }

        // collection.Should().NotBeEmpty()
        [Fact]
        public void Names_Collection_Should_NotBeEmpty()
        {
            var names = new List<string> { "Alice" };
            names.Should().NotBeEmpty();
        }

        // collection.Should().HaveCount(count)
        [Fact]
        public void Names_Collection_Should_HaveCount()
        {
            var names = new[] { "Alice", "Bob" };
            names.Should().HaveCount(2);
        }

        // collection.Should().HaveCountGreaterThan(value)
        [Fact]
        public void Names_Collection_Should_HaveCountGreaterThan()
        {
            var names = new[] { "Alice", "Bob", "Charlie" };
            names.Should().HaveCountGreaterThan(2);
        }

        // collection.Should().HaveCountLessThan(value)
        [Fact]
        public void Names_Collection_Should_HaveCountLessThan()
        {
            var names = new[] { "Alice" };
            names.Should().HaveCountLessThan(2);
        }

        // collection.Should().AllBeAssignableTo<T>()
        [Fact]
        public void Items_Should_AllBeAssignableTo_Object()
        {
            var items = new object[] { "text", 123, new Person() };
            items.Should().AllBeAssignableTo<object>();
        }

        // collection.Should().OnlyHaveUniqueItems()
        [Fact]
        public void Collection_Should_OnlyHaveUniqueItems()
        {
            var items = new[] { 1, 2, 3 };
            items.Should().OnlyHaveUniqueItems();
        }

        // dictionary.Should().ContainKey(key)
        [Fact]
        public void Dictionary_Should_ContainKey()
        {
            var dict = new Dictionary<string, int> { ["a"] = 1 };
            dict.Should().ContainKey("a");
        }

        // dictionary.Should().NotContainKey(key)
        [Fact]
        public void Dictionary_Should_NotContainKey()
        {
            var dict = new Dictionary<string, int> { ["a"] = 1 };
            dict.Should().NotContainKey("b");
        }

        // dictionary.Should().ContainValue(value)
        [Fact]
        public void Dictionary_Should_ContainValue()
        {
            var dict = new Dictionary<string, int> { ["a"] = 1 };
            dict.Should().ContainValue(1);
        }

        // dictionary.Should().NotContainValue(value)
        [Fact]
        public void Dictionary_Should_NotContainValue()
        {
            var dict = new Dictionary<string, int> { ["a"] = 1 };
            dict.Should().NotContainValue(2);
        }

        // action.Should().Throw()
        [Fact]
        public void ThrowingAction_Should_Throw()
        {
            Action action = () => throw new InvalidOperationException("boom");
            action.Should().Throw<InvalidOperationException>();
        }

        // action.Should().NotThrow()
        [Fact]
        public void SafeAction_Should_NotThrow()
        {
            var action = () => { };
            action.Should().NotThrow();
        }

        // action.Should().ThrowExactly<T>()
        [Fact]
        public void ThrowingAction_Should_ThrowExactly()
        {
            Action action = () => throw new ArgumentNullException();
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        // action.Should().Throw().WithMessage("message")
        [Fact]
        public void ThrowingAction_Should_Throw_WithMessage()
        {
            Action action = () => throw new InvalidOperationException("error occurred");
            action.Should().Throw<InvalidOperationException>().WithMessage("error occurred");
        }
    }
}