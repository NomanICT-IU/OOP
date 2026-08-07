using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Inheritance
{
    public class JSONWriter:XMLWriter
    {
        public void JSONWrite()
        {
            Console.WriteLine("I am from JSONWriter class");
        }
    }
}
