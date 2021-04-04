using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkbrute.Classes
{
    class Utils
    {
		public static string GenString(int length, bool upper, bool lower, bool digit)
		{
			Random rand = new Random(Guid.NewGuid().GetHashCode());
			string[] chars = null;
			string res = "";
			if (upper && !lower && !digit)
			{
				chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
			}
			else if (lower && !upper && !digit)
			{
				chars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
			}
			else if (digit && !upper && !lower)
			{
				chars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
			}
			else if (upper && lower && !digit)
			{
				chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
			}
			else if (upper && digit && !lower)
			{
				chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
			}
			else if (lower && digit && !upper)
			{
				chars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
			}
			else if (upper && lower && digit)
			{
				chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
			}
			for (int i = 0; i < length; i++)
            {
				rand = new Random(Guid.NewGuid().GetHashCode());
				res += chars.GetValue(rand.Next(0, chars.Length));
            }
			return res;
		}
	}
}
