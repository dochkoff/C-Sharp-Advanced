namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"../../../Files/input1.txt";
            var secondInputFilePath = @"../../../Files/input2.txt";
            var outputFilePath = @"../../../Files/output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader fisrtReader = new StreamReader(firstInputFilePath))
            {

                using (StreamReader secondReader = new StreamReader(secondInputFilePath))
                {

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string line1 = fisrtReader.ReadLine();
                        string line2 = secondReader.ReadLine();

                        while (line1 != null && line2 != null)
                        {
                            writer.WriteLine(line1);
                            writer.WriteLine(line2);

                            line1 = fisrtReader.ReadLine();
                            line2 = secondReader.ReadLine();
                        }

                    }
                }
            }
        }
    }
}
