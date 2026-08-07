using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceWithNewKeyWord
{
    public class JSONWriter : Writer
    {
        public JSONWriter(string fileName) : base(fileName)
        {

        }

        public new string GetDetails()
        {
            return ($"The file name is: {FileName}");
        }
    }
}
