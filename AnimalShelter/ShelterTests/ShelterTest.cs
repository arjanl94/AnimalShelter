using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace ShelterTests
{
    [TestClass]
    public class ShelterTest
    {
        [TestMethod]
        public void TestReservor()
        {
            Reservor reservor = new Reservor("Piet", DateTime.Now);
            Assert.AreEqual(reservor.Name, "Piet", "Naam is incorrect");
            //Assert.AreEqual(reservor.ReservedAt, DateTime.Now, "Datum is incorrect");
        }
        [TestMethod]
        public void TestCat()
        {
            Cat cat = new Cat("Kappa", Gender.Female, "Eigenwijs");
            Assert.AreEqual("Kappa", cat.Name, "Naam is incorrect");
            Assert.AreEqual(cat.gender, Gender.Female, "Geslacht is incorrect");
        }
        [TestMethod]
        public void TestDog()
        {
            Dog dog = new Dog("Roger", Gender.Male);
            Assert.AreEqual(dog.Name, "Roger", "Naam is incorrect");
            Assert.AreEqual(dog.gender, Gender.Male, "Geslacht is incorrect");
        }
        [TestMethod]
        public void TestReservation()
        {
            Reservation reservation = new Reservation();
            Assert.IsNull(reservation.cat, "Reservation heeft een cat object");
            reservation.NewCat("Hoi", Gender.Male, "Lui");
            Assert.IsNotNull(reservation.cat, "Reservation heeft geen cat object");
        }
    }
}
