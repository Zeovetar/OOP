using System;

namespace StringWorks
{
    public class Strings
    {
        public string ConvertString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string tempStr = new string(arr);
            return tempStr;
        }
    }

    public class Tests
    {
        public string str1 = "Пушка";
        public string str2 = "акшуП";
    }
}
