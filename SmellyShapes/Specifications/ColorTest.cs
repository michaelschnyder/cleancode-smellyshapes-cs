namespace SmellyShapes.Specifications
{
    using NUnit.Framework;

    using SmellyShapes.Source;

    [TestFixture]
    public class ColorTest {

        [Test]
        public void GetErrorMessage_InvalidColor()  
        {
            Color c = new Color("INVALIDColor_N4me");
            Assert.That(c.GetErrorMessage(), Is.EqualTo("Color not recognized"));
        }

        [Test]
        public void GetErrorMessage_Magenta()  
        {
            Color c = new Color("Magenta");
            Assert.That(c.GetErrorMessage(), Is.EqualTo("Color not recognized"));
        }

        [Test]
        public void GetErrorMessage_Cyan()  
        {
            Color c = new Color("Cyan");
            Assert.That(c.GetErrorMessage(), Is.EqualTo("Color not recognized"));
        }

        [Test]
        public void GetColorFormatted_Red()  
        {
            var color = new Color("Red");
            var colorFormatted = color.GetColorFormatted(false);
            Assert.That(colorFormatted, Is.EqualTo("Red"));
        }

        [Test]
        public void GetColorFormatted_Green()  
        {
            var color = new Color("Green");
            var colorFormatted = color.GetColorFormatted(false);
            Assert.That(colorFormatted, Is.EqualTo("Green"));
        }

        [Test]
        public void GetColorFormatted_Red_Incl()  
        {
            Color c = new Color("Red");
            string formattedColor = c.GetColorFormatted(true);
            Assert.That(formattedColor, Is.EqualTo("Red #FF0000 255:0:0"));
        }
        
    }
}
