using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class KMP_L
    {

        public static int prefixFunction(string pat, int[] pref)
        {
            int sz = pat.Length;

            for (int i = 1; i < sz; ++i)
            {
                int j = pref[i - 1];
                while (j > 0 && pat[i] != pat[j])
                {
                    j = pref[j - 1];
                }
                if (pat[i] == pat[j])
                {
                    ++j;
                }
                pref[i] = j;
            }

            foreach(int i in pref)
            {
                if (i != 0)
                    return 1;
            }

            return 0;
        }

        public static string search(string pat, string txt)
        {
            string log = "";
            int[] pref = new int[pat.Length];
            int resCheck = prefixFunction(pat, pref);

            #region Return value check
            if (resCheck == 0)
            {
                log += "\nLPS array has no sufixes\n";
            }
            else
            {
                log += "\nLSP Array : \n";
                foreach (char ch in pat)
                {
                    log += $" ({ch}) ";
                }
                log += "\n";
                foreach (int k in pref)
                {
                    log += $" ({k}) ";
                }
            }
            #endregion

            string logRes = "";

            int M = pat.Length;
            int N = txt.Length;

            int i = 0, j = 0;
            while (i < N)
            {   
                if(j == M)
                {
                    logRes += $"\nEntrance of ({pat}) at position ({i})";
                    i += j;
                    j = 0;
                    if (i == N)
                        break;
                }
                if (j > 0 && pat[j] != txt[i + j])
                {
                    i += j - pref[j];
                    j = 0;
                }
                if (pat[j] == txt[i + j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return log+logRes;
        }
    }
}
