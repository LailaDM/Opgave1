using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;

        [TestInitialize]
        public void SetUp()
        {
            _car = new Car(10,"Audi", 1000000, "AB12345");
        }



        [TestMethod]
        public void TestConstructor()
        {
            Car c = new Car(10, "Audi", 1000000, "AB12345");

            Assert.AreEqual("Audi", c.Model);
            Assert.AreEqual(1000000, c.Price);
            Assert.AreEqual("AB12345", c.LicensePlate);
        }

        [TestMethod]
        public void TestModel()
        {
            _car.Model = "Audi";
            Assert.AreEqual("Audi", _car.Model);
            Assert.ThrowsException<ArgumentException>(() => _car.Model = "ab");
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -1);
            _car.Price = 1000000;
            Assert.AreEqual(1000000, _car.Price);
        }

        [TestMethod]
            public void TestLicensePlate()
            {
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "a");
                _car.LicensePlate = "AB12345";
                Assert.AreEqual("AB12345", _car.LicensePlate);
            }

            
        }
    }
