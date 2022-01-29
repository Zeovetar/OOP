using System;

namespace Coder
{
	interface ICoder
	{
		public string Encode(string inputString);

		public string Decode(string inputString);
	}
    public class ACoder : ICoder
    {
        private bool checkStr(char[] chr)
        {
            bool pr = true;
            foreach (char ch in chr)
            {
                if ((int)ch < 1072 || (int)ch > 1104)
                {
                    pr =  false;
                }
            }
            return pr;
        }
        public string Decode(string inputString)
        {
            char[] charArr = inputString.ToCharArray();
            if (checkStr(charArr))
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    int ch = (int)charArr[i] - 1;
                    charArr[i] = (char)ch;
                }
            }
                return new string(charArr);
        }

        public string Encode(string inputString)
        {
            char[] charArr = inputString.ToCharArray();
            if (checkStr(charArr))
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    int ch = (int)charArr[i] + 1;
                    charArr[i] = (char)ch;
                }
            }
            return new string(charArr);
        }
    }
    public class BCoder : ICoder
    {
        private bool checkStr(char[] chr)
        {
            bool pr = true;
            foreach (char ch in chr)
            {
                if ((int)ch < 1072 || (int)ch > 1104)
                {
                    pr = false;
                }
            }
            return pr;
        }
        public string Decode(string inputString)
        {
            char[] charArr = inputString.ToCharArray();
            if (checkStr(charArr))
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    int counter = 1104 - (int)charArr[i];
                    charArr[i] = (char)(1072 + counter);
                }
            }
            return new string(charArr);
        }

        public string Encode(string inputString)
        {
            char[] charArr = inputString.ToCharArray();
            if (checkStr(charArr))
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    int counter = (int)charArr[i] - 1072;
                    charArr[i] = (char)(1104 - counter);
                }
            }
            return new string(charArr);
        }
    }
}
