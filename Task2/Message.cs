using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    class Message
    {
        public static void GetShorterWordsThan(string msg, int n)
        {
            msg = ClearString(msg);
            string[] words = msg.Split(' ');
            foreach (var word in words)
            {
                if (word.Length < n) { Console.WriteLine(word); }
            }
        }

        public static string DeleteWhatEndsOn(string msg, char c)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = msg.Split(' ');
            foreach (var word in words)
            {
                if (word[word.Length-1] == '.' || word[word.Length-1] == ',') 
                {
                    if (word[word.Length-2] != c)
                    {
                        sb.Append(word + ' ');
                    }
                } else if (word[word.Length-1] != c)
                {
                    sb.Append(word + ' ');
                }
            }
            
            return sb.ToString();
        }

        public static string FindLongestWord(string msg)
        {
            int max = 0;
            int index = 0;
            msg = ClearString(msg);
            string[] words = msg.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    index = i;
                }
            }
            return words[index];
        }

        public static string LongestWords(string msg)
        {
            StringBuilder sb = new StringBuilder();
            int len = FindLongestWord(msg).Length;
            msg = ClearString(msg);
            string[] words = msg.Split(' ');
            foreach (var word in words)
            {
                if (word.Length == len)
                {
                    sb.Append(word + ' ');
                }
            }
            return sb.ToString();
        }

        public static Dictionary<string, int> Analyse(string msg, string[] str)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            msg = ClearString(msg);
            string[] words = msg.Split(' ');
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                foreach (var word in words)
                {
                    if (word == str[i])
                    {
                        count++;
                    }
                }
                result.Add(str[i], count);
            }
            return result;
        }

        public static string ClearString(string msg)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == '.' || msg[i] == ',')
                {
                    msg = msg.Remove(i, 1);
                }
            }
            return msg.ToLower();
        }
    }
}
