using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie newTrie = new Trie();
            FileStream fs = new FileStream(@".\a.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            int ch, totalcount = 0;
            string temp = "";
            bool inString = false;
            while((ch = sr.Read())!= -1)
            {
                if(ch >= 65 && ch <= 90)
                {
                    temp += Convert.ToChar(ch);
                }
                else if(34 == ch)
                {
                    inString = !inString;
                    if(false == inString && temp != "")
                    {
                        newTrie.AddString(temp);
                        temp = "";
                        totalcount++;
                    }
                }
            }
            System.Console.WriteLine(newTrie.Calculate());
            System.Console.WriteLine(totalcount);
        }
    }
}
