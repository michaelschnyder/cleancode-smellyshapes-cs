namespace SmellyShapes.Specifications
{
    using System;
    using NUnit.Framework;

    using SmellyShapes.Source;

    [TestFixture]
    public class SquareTest
    {
        [Test]
        public void CalculateArea()
        {
            Square square = new Square(0, 0, 2);
            Assert.That(square.Calculate(), Is.EqualTo(4));
        }

        [Test]
        public void ToString_()
        {
            Square square = new Square(0, 0, 1, new Color("Red"));
            Assert.That(square.ToString(), Is.EqualTo("Square: (0:0) edgeLength=1 color=#FF0000"));
        }

        [Test]
        public void ToXml()
        {
            Square square = new Square(0, 1, 2);
            string xml = square.ToXml();
            Assert.That(xml, Is.EqualTo("<square x=\"0\" y=\"1\" edgeLength=\"2\" />\n"));
        }

        [Test]
        public void ContainsPoints()
        {
            Square square = new Square(0, 0, 1);

            Assert.That(square.ContainsPoint(0, 0), Is.True);
            Assert.That(square.ContainsPoint(0, 1), Is.True);
            Assert.That(square.ContainsPoint(1, 1), Is.True);
            Assert.That(square.ContainsPoint(1, 0), Is.True);

            Assert.That(square.ContainsPoint(-1, -1), Is.False);
            Assert.That(square.ContainsPoint(-1, 0), Is.False);
            Assert.That(square.ContainsPoint(0, -1), Is.False);
            Assert.That(square.ContainsPoint(1, 2), Is.False);
            Assert.That(square.ContainsPoint(2, 1), Is.False);
        }

        [Test]
        public void GetHeigth()
        {
            Assert.That(() => new Square(0, 0, 0).GetHeight(), Throws.Exception.TypeOf<InvalidOperationException>());
        }
    }
}
