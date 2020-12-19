﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP_L
    {
        public static int find(string text, string pat)
        {
            int i, j, N, M;

            N = text.Length;
            M = pat.Length;
            int[] d = new int[M];

            d[0] = 0;

            for (i = 0, j = 0; i < M; i++)
            {
                while (j > 0 && pat[j] != pat[i])
                {
                    j = d[j - 1];
                }
                if (pat[j] == pat[i])
                {
                    j++;
                }
                d[i] = j;
            }

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
