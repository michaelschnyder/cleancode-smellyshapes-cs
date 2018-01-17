namespace AdditionalExercises.FileWriter
{
    using System;
    using System.IO;

    public class FileWriterFlagExample
    {
        public static void Main(String[] args) 
        {
            var file = File.ReadAllText("C:\\temp\\example.txt");

            // hard to understand ???
            FileWriter fileWriter = new FileWriter(file, true);
            FileWriter fileWriter2 = new FileWriter(file, false);


            // define readable constants??
            bool APPEND_MODE = true;
            bool OVERWRITE_MODE = false;
            FileWriter appendingfileWriter = new FileWriter(file, APPEND_MODE);
            FileWriter overwritingfileWriter = new FileWriter(file, OVERWRITE_MODE);


            // Enums?

        
        }
    }
}

