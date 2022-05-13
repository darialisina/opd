using NUnit.Framework;

namespace lab1_task2
{
    public class UnitTests_task2
    {
        [Test]
        public void Subscriber1Login()
        {
            Subscriber1 subscriber1 = new Subscriber1("Dasha");
            string login = subscriber1.Login;

            string res = "Dasha";

            Assert.AreEqual(res, login);
        } 
    }
}
