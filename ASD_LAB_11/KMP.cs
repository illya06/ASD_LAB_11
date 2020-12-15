using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP
    {
        public static string KMPSearch(string pat, string txt)
        {
            string log = "";

            int[] lps = new int[pat.Length];
            int j = 0;

            computeLPSArray(pat, pat.Length, lps);
            log += $"\nKey word : {pat}";
            log += "\nLSP ARRAY : \n";
            foreach(int d in lps)
            {
                log += $" {d} ";
            }
            log += "\n";
            foreach (char ch in pat)
            {
                log += $" {ch} ";
            }

            int i = 0;
            while (i < txt.Length)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }

                if (j == pat.Length)
                {
                    log += $"\n At ({i - j}) : Entry of {pat}";
                    j = lps[j - 1];
                }
                else if (i < txt.Length && pat[j] != txt[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }

            return log;
        }

        public static void computeLPSArray(string pat, int M, int[] lps)
        {
            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i < M)
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
        }
    }
}
