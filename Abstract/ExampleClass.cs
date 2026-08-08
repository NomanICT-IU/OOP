namespace Abstract
{
    public class ExampleClass : AbstractClass
    {
        /// <summary>
        /// The method take a string argument and print this argument.
        /// </summary>
        /// <param name="text"></param>
        public override void PrintToConsole(string text)
        {
            Console.WriteLine(text);
        }
    }
}
