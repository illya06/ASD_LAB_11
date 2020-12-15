using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASD_LAB_11
{
    class Task14
    {
        public static string[] search(string text)
        {
            string[] result = new string[2];
            string[] words = text.Split(' ', ',', '.', ':', '\t');
            string editedText = text;
            string keyWord = "";
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (map.ContainsKey(word))
                    map[word]++;
                else
                    map[word] = 1;
            }

            int max = -1;
            foreach (KeyValuePair<string, int> kvp in map)
                if (kvp.Value > max)
                    max = kvp.Value;

            foreach (KeyValuePair<string, int> kvp in map)
                if (kvp.Value == max)
                    keyWord = kvp.Key;
            if (keyWord != "")
                Regex.Replace(editedText, $"\\b{keyWord}\\b", "");

            result[0] = editedText;
            result[1] = keyWord;
            return result;
        }
    }
}
