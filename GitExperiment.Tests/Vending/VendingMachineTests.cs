using NUnit.Framework;

namespace GitExperiment.Tests.Vending
{
    [TestFixture]
    public class VendingMachineTests
    {
        [Test]
        public void Empty_Has_0_Credits()
        {
            var machine = new VendingMachine();
            Assert.That(machine.Credit, Is.EqualTo(0));
        }

        [Test]
        public void Insert_1_Coin()
        {
            var machine = new VendingMachine();
            machine.Insert(1);
            Assert.That(machine.Credit, Is.EqualTo(1));
        }

        [Test]
        public void Insert_1_Coin_Twice()
        {
            var machine = new VendingMachine();
            machine.Insert(1);
            machine.Insert(1);
            Assert.That(machine.Credit, Is.EqualTo(2));
        }

        [Test]
        public void Insert_2_Coin()
        {
            var machine = new VendingMachine();
            machine.Insert(2);
            Assert.That(machine.Credit, Is.EqualTo(2));
        }

    }
}