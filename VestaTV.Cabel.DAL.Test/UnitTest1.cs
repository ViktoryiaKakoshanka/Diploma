using Xunit;

namespace VestaTV.Cabel.DAL.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var db = new UnitOfWork();
            var a = db.Users.GetAll();
            Assert.Single(a);
        }
    }
}
