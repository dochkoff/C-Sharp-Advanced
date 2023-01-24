namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"../../../Files/example.png";
            string joinedFilePath = @"../../../Files/example-joined.png";
            string partOnePath = @"../../../Files/part-1.bin";
            string partTwoPath = @"../../../Files/part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] bytesRead = File.ReadAllBytes(sourceFilePath);

            if (bytesRead.Length % 2 == 0)
            {
                byte[] partOneToWrite = new byte[bytesRead.Length / 2];
                byte[] partTwoToWrite = new byte[bytesRead.Length / 2];

                for (int i = 0; i < bytesRead.Length / 2; i++)
                {
                    partOneToWrite[i] = bytesRead[i];
                }

                for (int i = bytesRead.Length / 2; i < bytesRead.Length; i++)
                {
                    partTwoToWrite[i] = bytesRead[i];
                }

                File.WriteAllBytes(partOneFilePath, partOneToWrite);
                File.WriteAllBytes(partTwoFilePath, partTwoToWrite);
            }
            else
            {
                byte[] partOneToWrite = new byte[bytesRead.Length / 2 + 1];
                byte[] partTwoToWrite = new byte[bytesRead.Length / 2];

                for (int i = 0; i < bytesRead.Length / 2 + 1; i++)
                {
                    partOneToWrite[i] = bytesRead[i];
                }

                for (int i = 0; i < bytesRead.Length / 2; i++)
                {
                    partTwoToWrite[i] = bytesRead[i + bytesRead.Length / 2 + 1];
                }

                File.WriteAllBytes(partOneFilePath, partOneToWrite);

                File.WriteAllBytes(partTwoFilePath, partTwoToWrite);

            }

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] partOneBytes = File.ReadAllBytes(partOneFilePath);
            byte[] partTwoBytes = File.ReadAllBytes(partTwoFilePath);

            byte[] allFileBytes = partOneBytes.Concat(partTwoBytes).ToArray();



            File.WriteAllBytes(joinedFilePath, allFileBytes);
        }
    }
}