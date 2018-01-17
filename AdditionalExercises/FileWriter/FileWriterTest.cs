namespace AdditionalExercises.FileWriter
{
    using NUnit.Framework;

    [TestFixture]
    public class FileWriterTest
    {
        [Test]
        public void TestWriteContentInOverwriteMode()
        {
            FileWriter replacingFileWriter = new FileWriter("Initial Content", false);

            replacingFileWriter.Write("New Content", false);

            Assert.That(replacingFileWriter.GetContent(), Is.EqualTo("New Content"));
        }

        [Test]
        public void TestWriteContentInAppendMode()
        {
            FileWriter appendingFileWriter = new FileWriter("Initial Content", true);

            appendingFileWriter.Write("New Content", false);

            Assert.That(appendingFileWriter.GetContent(), Is.EqualTo("Initial Content" + "New Content"));
        }

        [Test]
        public void TestWriteWithoutFlush()
        {
            FileWriter appendingFileWriter = new FileWriter("Initial Content", true);

            appendingFileWriter.Write("New Content", false);

            Assert.That(appendingFileWriter.GetContent(), Is.EqualTo("Initial Content" + "New Content"));
            Assert.That(appendingFileWriter.IsContentFlushed(), Is.False);
        }

        [Test]
        public void TestWriteWithFlush()
        {
            FileWriter appendingFileWriter = new FileWriter("Initial Content", true);

            appendingFileWriter.Write("New Content", true);

            Assert.That(appendingFileWriter.GetContent(), Is.EqualTo("Initial Content" + "New Content"));
            Assert.That(appendingFileWriter.IsContentFlushed(), Is.True);
        }

        [Test]
        public void TestFlushContent()
        {
            FileWriter appendingFileWriter = new FileWriter("Initial Content", true);

            appendingFileWriter.FlushContent();

            Assert.That(appendingFileWriter.IsContentFlushed(), Is.True);
        }
    }
}
