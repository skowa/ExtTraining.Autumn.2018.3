namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomCharsFileGenerator generatorChars = new RandomCharsFileGenerator();
            generatorChars.GenerateFiles(5, 100);

            RandomBytesFileGenerator generatorBytes = new RandomBytesFileGenerator();
            generatorBytes.GenerateFiles(5, 100);
        }
    }
}
