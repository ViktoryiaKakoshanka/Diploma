using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VestaTV.Cabel.Core.Models;
using VestaTV.Cable.BLL.Interfaces;
using VestaTV.Cable.BLL.Services;

namespace VestaTV.Cabel.BLL.Tests
{
    public class MasterServiseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var masterServis = new MasterServis();

            masterServis.AddNewMaster(new Master() { Brigade = false, Name = "123" });

            var masters = masterServis.GetMasters();
            Assert.AreEqual(1, masters.Count());
        }
    }
}