namespace AdditionalExercises.MathUtils
{
    using NUnit.Framework;

    [TestFixture]
    public class MathUtilsTest
    {
        [Test]
        public void testIsDivisibleBy3_Given_FactorsOf_3()
        {
            Assert.That(MathUtils.IsDivisibleBy3(3), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(6), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(9), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(15), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(30), Is.True);
        }

        [Test]
        public void testIsDivisibleBy3_Given_Negative_FactorsOf_3()
        {
            Assert.That(MathUtils.IsDivisibleBy3(-3), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(-6), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(-9), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(-15), Is.True);
            Assert.That(MathUtils.IsDivisibleBy3(-30), Is.True);
        }

        [Test]
        public void testIsDivisibleBy3_Given_FailingInputs()
        {
            Assert.That(MathUtils.IsDivisibleBy3(2), Is.False);
            Assert.That(MathUtils.IsDivisibleBy3(4), Is.False);
            Assert.That(MathUtils.IsDivisibleBy3(10), Is.False);
        }

        [Test]
        public void testIsDivisibleBy3_Given_SpecialInputs()
        {
            // 0 is dividable by every number
            Assert.That(MathUtils.IsDivisibleBy3(0), Is.True);
            // 1 isn't dividable by any number exept 1 itself
            Assert.That(MathUtils.IsDivisibleBy3(1), Is.False);
        }

        // ----------------------------------------------------------

        [Test]
        public void testIsDivisibleBy5_FactorsOf_5()
        {
            Assert.That(MathUtils.IsDivisibleBy5(5), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(10), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(15), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(30), Is.True);
        }

        [Test]
        public void testIsDivisibleBy5_Given_Negative_FactorsOf_5()
        {
            Assert.That(MathUtils.IsDivisibleBy5(-5), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(-10), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(-15), Is.True);
            Assert.That(MathUtils.IsDivisibleBy5(-30), Is.True);
        }

        [Test]
        public void testIsDivisibleBy5_Given_FailingInputs()
        {
            Assert.That(MathUtils.IsDivisibleBy5(4), Is.False);
            Assert.That(MathUtils.IsDivisibleBy5(6), Is.False);
        }

        [Test]
        public void testIsDivisibleBy5_Given_SpecialInputs()
        {
            // 0 is dividable by every number
            Assert.That(MathUtils.IsDivisibleBy5(0), Is.True);
            // 1 isn't dividable by any number exept 1 itself
            Assert.That(MathUtils.IsDivisibleBy5(1), Is.False);
        }
    }
}