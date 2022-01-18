﻿using System;

namespace RationalNumbers
	{

	public class Numbers
	{
		private int numerator;
		private int denumerator;

		public int Numerator { get { return this.numerator; } set { this.numerator = value; } }
		public int Denumerator { get { return this.denumerator; } set { this.numerator = value; } }
		public Numbers(int numerator, int denumerator)
		{
			this.numerator = numerator;
			this.denumerator = denumerator;
		}

		public Numbers(Numbers clone)
		{
			this.numerator = clone.numerator;
			this.denumerator = clone.denumerator;
		}
		public static void nod(Numbers fraction1, Numbers fraction2)
		{
			for (int i = 2; i < 10; i++)
			{
				if (fraction1.numerator % i == 0 && fraction1.denumerator % i == 0 && fraction2.numerator == 0 && fraction2.denumerator == 0)
				{
					fraction1.numerator = fraction1.numerator / i;
					fraction1.denumerator = fraction1.denumerator / i;
					fraction2.numerator = fraction2.numerator / i;
					fraction2.denumerator = fraction2.denumerator / i;
					nod(fraction1, fraction2);
				}
			}
		}

		public static void nok(Numbers fraction1, Numbers fraction2)
		{
			int nok1 = fraction1.denumerator;
			int nok2 = fraction2.denumerator;
			if (nok1 != nok2)
			{
				fraction1.numerator = fraction1.numerator * nok2;
				fraction1.denumerator = fraction1.denumerator * nok2;
				fraction2.numerator = fraction2.numerator * nok1;
				fraction2.denumerator = fraction2.denumerator * nok1;
			}
		}

		public static bool operator ==(Numbers fraction1, Numbers fraction2)
		{
			Numbers fraction_1 = new(fraction1);
			Numbers fraction_2 = new(fraction2);
			//nod(fraction1, fraction2);
			nok(fraction_1, fraction_2);
			if (fraction_1.numerator / fraction_2.numerator == 1 && fraction_1.numerator % fraction_2.numerator == 0)
			{
				return true;
			}
			return false;
		}

		public static bool operator !=(Numbers fraction1, Numbers fraction2)
		{
			if (fraction1 == fraction2)
			{
				return false;
			}
			return true;
		}

		public bool Equals(Numbers fraction)
		{
			nok(this, fraction);
			if (this == fraction)
			{
				return true;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return 1;
		}

        public static Numbers operator +(Numbers fraction1, Numbers fraction2)
        {
            nok(fraction1, fraction2);
            Numbers ans = new(0, 1);
            ans.numerator = fraction1.numerator + fraction2.numerator;
            ans.denumerator = fraction1.denumerator;
            return ans;
        }

		public static Numbers operator -(Numbers fraction1, Numbers fraction2)
		{
			nok(fraction1, fraction2);
			Numbers ans = new(0, 1);
			ans.numerator = fraction1.numerator - fraction2.numerator;
			ans.denumerator = fraction1.denumerator;
			return ans;
		}

		public static Numbers operator ++(Numbers fraction)
		{
			fraction.numerator = fraction.numerator + fraction.denumerator;
			return fraction;
		}

		public static Numbers operator --(Numbers fraction)
		{
			fraction.numerator = fraction.numerator - fraction.denumerator;
			return fraction;
		}

		public static bool operator <(Numbers fraction1, Numbers fraction2)
		{
			nok(fraction1, fraction2);
			if (fraction1.numerator % fraction2.numerator > 0 && fraction1.numerator % fraction2.numerator < 1)
			{
				return true;
			}
			return false;
		}

		public static bool operator >(Numbers fraction1, Numbers fraction2)
		{
			nok(fraction1, fraction2);
			if (fraction1.numerator % fraction2.numerator > 0 && fraction1.numerator % fraction2.numerator < 1)
			{
				return false;
			}
			return true;
		}

		public static bool operator <=(Numbers fraction1, Numbers fraction2)
		{
			nok(fraction1, fraction2);
			if ((fraction1.numerator % fraction2.numerator > 0 && fraction1.numerator % fraction2.numerator < 1) ||
				(fraction1.numerator % fraction2.numerator == 0 && fraction1.numerator / fraction2.numerator == 1))
			{
				return true;
			}
			return false;
		}

		public static bool operator >=(Numbers fraction1, Numbers fraction2)
		{
			nok(fraction1, fraction2);
			if ((fraction1.numerator % fraction2.numerator > 0 && fraction1.numerator % fraction2.numerator < 1) || 
				(fraction1.numerator % fraction2.numerator == 0 && fraction1.numerator / fraction2.numerator == 1))
			{
				return true;
			}
			return false;
		}

		public override string ToString(Numbers fraction)
		{
			string outString = $"{fraction.numerator}.{fraction.denumerator}";
			Console.WriteLine("Hi there!", outString);
			return outString;
		}
	}
}
