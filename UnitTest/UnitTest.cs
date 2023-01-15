using Classes;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddGift()
        {
            Sleigh sleigh = new Sleigh("Slitta di Babbo Natale", 100.0, 1000.0);
            Gift gift1 = new Gift("Trenino", "Nero", 10.0, 100.0);
            Gift gift2 = new Gift("Trenino", "Nero", 100.0, 100.0);

            Assert.That(sleigh.AddGift(gift1), Is.True);
            Assert.That(sleigh.AddGift(gift2), Is.False);
        }
    }
}