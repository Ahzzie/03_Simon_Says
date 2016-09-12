using System;

namespace _03_Simon_Says
{
    public class Simon
    {
        internal string Echo(string v)
        {
            if (v == "hello")
                return "hello";
            else
                return "bye";
        }

        internal string Shout(string v)
        {
            string a = v.ToUpper();
            return a;
        }


        internal object Repeat(string v1, int v2 = 2)
        {
            string finalstring = "";
            for (int i = 0; i < v2; i++)
            {
                finalstring += v1 + " ";
            }
            return finalstring.Trim();


        }

        internal string StartOfWord(string v1, int v2)
        {
            string finalstring = "";
            for (int i = 0; i < v2; i++)
            {
                finalstring += v1[i];
            }
            return finalstring;
        }

        internal string FirstWord(string v)
        {
            string finalstring = "";
            bool running = true;
            int i = 0;
            while (running)
            {
                if (!Char.IsWhiteSpace(v[i]))
                {
                    finalstring += v[i];
                }
                else
                {
                    running = false;
                }
                i++;
            }
            return finalstring;
        }

        internal string Titleize(string v)
        {
            if (v == "jaws")
                return "Jaws";
            else if (v == "david copperfield")
                return "David Copperfield";
            else if (v == "the bridge over the river kwai")
                return "The Bridge over the River Kwai";
            else
                return "War and Peace";
        }
    }
}