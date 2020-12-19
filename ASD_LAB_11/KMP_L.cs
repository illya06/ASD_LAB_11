using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP_L
    {
        public static int computeLPSArray(string pat, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i < pat.Length)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }

            //return
            #region return value calculation
            int ret = 0;
            foreach (int el in lps)
            {
                if (el != 0)
                    ret = 1;
            }
            #endregion
            return ret;
        }

        public static int find(string text, string pat)
        {
            int i, j, N, M;

            N = text.Length;
            M = pat.Length;
            int[] d = new int[M];

            computeLPSArray(pat, d);

            //search
            i = 0; j = 0;
            while (i < N - j)
            {
                while (j > 0 && pat[j] != text[i])
                {
                    i = i + j - d[j - 1] - 1;
                }
                if (pat[j] == text[i])
                {
                    j++;
                }
                if (j == M)
                {
                    return i - j + 1;
                }
            }
            return -1;
        }
    }
}
