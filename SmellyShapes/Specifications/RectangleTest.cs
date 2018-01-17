namespace SmellyShapes.Specifications
{
    using SmellyShapes.Source;

    using NUnit.Framework;

    [TestFixture]
    public class RectangleTest
    {
        private Rectangle rectangle;

        [SetUp]
        public void SetUp()  
        {
            rectangle = new Rectangle(0, 0, 2, 1);
        }

        [Test]
        public void Contains()  
        {
            Assert.That(rectangle.Contains(0, 0), Is.True);
            Assert.That(rectangle.Contains(1, 0), Is.True);
            Assert.That(rectangle.Contains(1, 1), Is.True);
            Assert.That(rectangle.Contains(2, 1), Is.True);

            Assert.That(rectangle.Contains(2, 2) , Is.False);
            Assert.That(rectangle.Contains(-1, 0), Is.False);
            Assert.That(rectangle.Contains(0, -1), Is.False);
        }

        [Test]
        public void CalculateArea()  
        {
            Assert.That(rectangle.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void ToXml()  
        {
            string xml = rectangle.ToXml();

            Assert.That(xml, Is.EqualTo("<rectangle x=\"0\" y=\"0\" width=\"2\" height=\"1\" />\n"));
        }

        [Test]
        public void RectangleToString()
        {
            string xml = rectangle.ToString();
            Assert.That(xml, Is.EqualTo("Rectangle: (0) width=0 height=2 color=1"));
        }
    }
}

