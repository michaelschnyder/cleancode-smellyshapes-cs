namespace AdditionalExercises.PersonExample
{
    using NUnit.Framework;

    [TestFixture]
    public class PersonTest
    {
        [Test]
        public void ToString_defaultMode()
        {
            Person simon = new Person("Ammann", "Simon", "CH");
            Assert.That(simon.ToString(), Is.EqualTo("Simon Ammann"));
        }

        [Test]
        public void ToString_olympicModeAndCapitalize()
        {
            Person simon = new Person("Ammann", "Simon", "CH", true, true);
            Assert.That(simon.ToString(), Is.EqualTo("Simon AMMANN"));
        }

        [Test]
        public void ToString_chineseInNonOlympicNonCapitalize()
        {
            Person yao = new Person("Yao", "Ming", "CHN", false, false);
            Assert.That(yao.ToString(), Is.EqualTo("Ming Yao"));
        }

        [Test]
        public void ToString_chineseInOlympicMode()
        {
            Person yao = new Person("Yao", "Ming", "CHN", true, false);
            Assert.That(yao.ToString(), Is.EqualTo("Yao Ming"));
        }

        [Test]
        public void ToString_chineseInOlympicModeAndCapitalize()
        {
            Person yao = new Person("Yao", "Ming", "CHN", true, true);
            Assert.That(yao.ToString(), Is.EqualTo("YAO Ming"));
        }
    }
}