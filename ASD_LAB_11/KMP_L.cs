using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP_L
    {

        public static int[] prefixFunction(string pattern)
        {
            int sz = pattern.Length;
            int[] prefix = new int[sz];

            for (int i = 1; i < sz; ++i)
            {
                int j = prefix[i - 1];
                while (j > 0 && pattern[i] != pattern[j])
                {
                    j = prefix[j - 1];
                }
                if (pattern[i] == pattern[j])
                {
                    ++j;
                }
                prefix[i] = j;
            }

            return prefix;
        }

        public static int KMPsearch(string pattern, string text)
        {
            int[] prefix = prefixFunction(pattern);

            int M = pattern.Length;
            int N = text.Length;

            int i = 0, j = 0;
            while (i < N)
            {
                if (j > 0 && pattern[j] != text[i + j])
                {
                    i += j - prefix[j];
                    j = 0;
                }
                if (pattern[j] == text[i + j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
                if (j == M)
                {
                    return i;
                }
            }

            return -1;
        }

        public static string search(string pattern, string text)
        {
            int res = KMPsearch(pattern, text);
            if (res != -1)
            {
                return $"\nFound entrance of ({pattern}) on position ({res})";
            }
            return $"\n There is no ({pattern})";
        }
    }
}
