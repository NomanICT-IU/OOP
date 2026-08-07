using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Inheritance
{
    public class XMLWriter:Writer
    {
        public void XMLWrite()
        {
            Console.WriteLine("I am from XMLWriter class.");
        }
    }
}
