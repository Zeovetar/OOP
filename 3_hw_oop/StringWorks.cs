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
        public string str1;
        public string str2;
        public Tests(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }

    }
}
