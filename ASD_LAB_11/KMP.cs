﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP
    {
        public static void KMPSearch(string pat, string txt)
        {
            int M = pat.Length;
            int N = txt.Length;

            int[] lps = new int[M];
            int j = 0;

            computeLPSArray(pat, M, lps);

            int i = 0;
            while (i < N)
            {
                if (pat[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == M)
                {
                    Console.Write("Found pattern "
                                  + "at index " + (i - j));
                    j = lps[j - 1];
                }

                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;
                }
            }
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
