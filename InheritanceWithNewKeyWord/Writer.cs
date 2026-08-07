using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InheritanceWithNewKeyWord
{
    public class Writer
    {
        private string _fileName;
        public Writer(string fileName)
        {
            _fileName = fileName;
        }

        public string FileName { get => _fileName;  }

        public string GetDetails()
        {
            return ($"The file name is: {_fileName}");
        }
    }
}
