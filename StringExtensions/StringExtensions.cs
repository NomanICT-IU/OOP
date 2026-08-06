using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions;

public static class StringExtensions
{
    public static string FirstUpperLetterCase(this string word) {

        char letter = Char.ToUpper(word[0]);
        string remaining = word.Substring(1);
        return letter + remaining;

    }
}
