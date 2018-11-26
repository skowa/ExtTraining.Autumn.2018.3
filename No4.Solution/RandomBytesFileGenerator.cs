using System;
using System.IO;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public RandomBytesFileGenerator()
        {
            WorkingDirectory = "Files with random bytes";
            FileExtension = ".bytes";
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        protected override void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}