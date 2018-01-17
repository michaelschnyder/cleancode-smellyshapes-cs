namespace SmellyShapes.Specifications
{
    using NUnit.Framework;

    using SmellyShapes.Source;

    [TestFixture]
    public class ShapeGroupTest
    {

        [Test]
        public void TooXml()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.Add(new Rectangle(0, 0, 2, 1));

            string xml = shapeGroup.ToXml();

            Assert.That(
                xml, Is.EqualTo(
                "<shapegroup>\n<rectangle x=\"0\" y=\"0\" width=\"2\" height=\"1\" />\n</shapegroup>\n"));
        }

        [Test]
        public void Constructor_WithShapeArray()
        {
            ShapeGroup shapeGroup = new ShapeGroup(new IShape[] { new Circle(0, 0, 0) }, true);

            Assert.That(shapeGroup.size, Is.EqualTo(1));
        }

        [Test]
        public void Add_WithReadOnly()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(true);

            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.That(shapeGroup.size, Is.EqualTo(0));
        }

        [Test]
        public void Add_WithoutReadOnly()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.That(shapeGroup.size, Is.EqualTo(1));
        }

        [Test]
        public void Add_SameElementTwice()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            Circle circle = new Circle(0, 0, 0);
            shapeGroup.Add(circle);
            shapeGroup.Add(circle);

            Assert.That(shapeGroup.size, Is.EqualTo(1));
        }

        [Test]
        public void Add_InternalArraySizeExceeded()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            for (int i = 0; i < 11; i++)
            {
                shapeGroup.Add(new Circle(0, 0, 0));
            }

            Assert.That(shapeGroup.size, Is.EqualTo(11));
        }

        [Test]
        public void Contains_PointNotInGroup()
        {
            ShapeGroup shapeGroup = new ShapeGroup();

            Assert.That(shapeGroup.Contains(0, 0), Is.False);
        }

        [Test]
        public void Contains_PointInGroup()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.That(shapeGroup.Contains(0, 0), Is.True);
        }

        [Test]
        public void Contains_Null()
        {
            ShapeGroup shapeGroup = new ShapeGroup();

            Assert.That(shapeGroup.Contains(null), Is.False);
        }

        [Test]
        public void Contains_ShapeInGroup()
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            Circle c = new Circle(0, 0, 0);
            shapeGroup.Add(c);

            Assert.That(shapeGroup.Contains(c), Is.True);
        }
    }
}
