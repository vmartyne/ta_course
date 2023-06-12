using Homework_Person;

namespace UnitTest1;

public class Tests
{
    Person person;
    [SetUp]
    public void Setup()
    {
        person = new Person();
        person.FirstName = "John";
        person.LastName = "Doe";
    }

    [Test]
    public void TestFirstNameIsJohn()
    {
        Assert.That(person.FirstName, Is.EqualTo("Joe")); // Check if Name is Joe
    }

    [Test]
    public void TestFirstNameValidation()
    {
        Assert.Throws<ArgumentException>(() => person.FirstName = "1234"); // Check if First name cannot be digits
        Assert.Throws<ArgumentException>(() => person.FirstName = ""); // Check if First name cannot be empty
        Assert.Throws<ArgumentException>(() => person.FirstName = "Qwertyuioplkjhgfdsazxcvbnmkloyt"); // Check if First name cannot be more then 30 charecters
        Assert.Throws<ArgumentException>(() => person.FirstName = "Пилип"); // Check if First name cannot be cyrillic
    }

    [Test]
    public void TestLastNameIsDoe()
    {
        Assert.That(person.LastName, Is.EqualTo("Doe")); // Check if Surname is Doe
    }
    /*
    [TestCase("", true)]
    [TestCase("Qwertyuioplkjhgfdsazxcvbnmkloyt", true)]

    public void TestLastNameValidation(string testData, bool expected)
    {
        Assert.That(person.LastName(testData), Is.EqualTo(expected));
    }
    */
}

