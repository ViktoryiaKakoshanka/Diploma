using NUnit.Framework;
using System.Linq;
using VestaTV.Cabel.DAL;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var db = new UnitOfWork();
            var a = db.Users.GetAll();
            Assert.AreEqual(1, a.Count());
        }
    }
}