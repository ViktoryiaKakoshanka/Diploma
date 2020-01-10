using NUnit.Framework;
using System.Linq;
using VestaTV.Cable.BLL.Services;
using Moq;
using VestaTV.Cabel.DAL.Interfaces;
using VestaTV.Cabel.Core.Models;
using System.Collections.Generic;

namespace VestaTV.Cabel.BLL.Tests
{
    public class MasterServiseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BLLMasterServisGetMastersReturn2Test()
        {
            var master = new Master() { Brigade = false, Name = "123" };
            var expectedMasters = new List<Master>() { master, master };

            var mock = new Mock<IDataAccess>();
            mock.Setup(d => d.GetMasters()).Returns(expectedMasters);

            var masterServis = new MasterServis(mock.Object);

            var actualMasters = masterServis.GetMasters();
            Assert.AreEqual(2, actualMasters.Count());
        }
    }
}