using Homework_Person;

namespace UnitTest1;

public class Tests
{
    Person person;
    [SetUp]
    public void Setup()
    {
        person = new Person();
    }

    [Test]
    public void Test1()
    {
        Assert.That(1, Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        Assert.Throws<ArgumentException>(() => person.FirstName = "Name");
    }
}

