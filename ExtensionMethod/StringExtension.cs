using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod;

public static class StringExtension
{
    public static string ChangeFirstLetter(this string word)
    {
        char letter = Char.ToUpper(word[0]);
        string reamining = word.Substring(1);

        return letter + reamining;
    }
}
