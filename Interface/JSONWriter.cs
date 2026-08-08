namespace Interface
{
    internal class JSONWriter : IWriter
    {
        private string _fileName;

        public JSONWriter(string fileName)
        {
            _fileName = fileName;
        }

        public string FileName { get => _fileName; }

        public void WriteFile(string fileName)
        {
            Console.WriteLine($"The file name is: {fileName}");
        }
    }
}
