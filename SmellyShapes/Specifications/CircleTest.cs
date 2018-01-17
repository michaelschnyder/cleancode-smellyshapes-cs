namespace SmellyShapes.Specifications
{
    using NUnit.Framework;

    using SmellyShapes.Source;

    [TestFixture]
    public class CircleTest
    {
        private Circle circle;

        [SetUp]
        public void SetUp()
        {
            circle = new Circle(0, 0, 1);
            circle.SetColor(new Color("Red"));
        }

        [Test]
        public void Contains()
        {
            Assert.That(circle.Contains(0, 0), Is.True);
            Assert.That(circle.Contains(0, 1), Is.True);
            Assert.That(circle.Contains(1, 0), Is.True);

            Assert.That(circle.Contains(1, 1), Is.False);
            Assert.That(circle.Contains(-1, -1), Is.False);
            Assert.That(circle.Contains(1, -1), Is.False);
            Assert.That(circle.Contains(-1, 1), Is.False);
        }

        [Test]
        public void CountContainingPoints()
        {
            int result = circle.CountContainingPoints(new[] { 0, 10 }, new[] { 0, 10 });
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ToXml()
        {
            string xml = circle.ToXml();
            Assert.That(xml, Is.EqualTo("<circle x=\"0\" y=\"0\" radius=\"1\" />\n"));
        }

        [Test]
        public void ToString_()
        {
            Assert.That(circle.ToString(), Is.EqualTo("Circle: (0,0) radius= 1 RGB=255,0,0"));
        }
    }
}
