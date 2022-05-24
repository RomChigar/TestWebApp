namespace WebApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCar()
        {
            Car car = new Car();

            car.Name = "toto";

            Assert.That(car.Name, Is.Not.Null);
        }
    }
}