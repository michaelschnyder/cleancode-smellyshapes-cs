namespace AdditionalExercises.FileWriter
{
    /// <summary>
    /// Demonstration of Flag Parameters
    /// </summary>
    public class FileWriter
    {
        private string content;
        private readonly bool isInAppendMode;
        private bool isContentFlushed;

        public FileWriter(string newContent, bool useAppendMode)
        {
            this.content = newContent;
            this.isInAppendMode = useAppendMode;
            this.isContentFlushed = false;
        }

        public void Write(string contentToWrite, bool doFlushContent)
        {
            this.isContentFlushed = false;

            if (this.isInAppendMode)
            {
                this.content += contentToWrite;
            }
            else
            {
                this.content = contentToWrite;
            }

            if (doFlushContent)
            {
                this.FlushContent();
            }
        }

        public void FlushContent()
        {
            this.isContentFlushed = true;
        }

        public string GetContent()
        {
            return this.content;
        }

        public bool IsInAppendMode()
        {
            return this.isInAppendMode;
        }

        public bool IsContentFlushed()
        {
            return this.isContentFlushed;
        }
    }
}