using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Trie
{
    class Program
    {
        static int GlobalCount = 0;
        static void Main(string[] args)
        {
            Trie newTrie = new Trie();
            FileStream fs = new FileStream(@".\names.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            int ch, sum = 0, totalcount = 0;
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

            for(int i = 0; i < 26; i++)
            {
                while(newTrie.Head.child[i].count != 0)
                {
                    sum += TraversalTrie(newTrie.Head.child[i], 0, "");
                    //System.Console.WriteLine();
                }
            }

            System.Console.WriteLine(sum);
            System.Console.WriteLine(GlobalCount);
        }


        static private int TraversalTrie(TrieNode StartNode, int Sum, string name)
        {
            name += (char)(StartNode.value + 64);
            Sum += StartNode.value;
            StartNode.count--;
            if (!StartNode.hasChild)
            {
                System.Console.WriteLine(name);
                return Sum * (++GlobalCount);
            }

            int count = 0;
            for (int i = 0; i < 26; i++ )
            {
                count += StartNode.child[i].count;
            }

            if (count <= StartNode.count)
            {
                System.Console.WriteLine(name);
                return Sum * (++GlobalCount);
            }
            else
            {
                for (int i = 0; i < 26; i++)
                {
                    if (StartNode.child[i].count != 0) return TraversalTrie(StartNode.child[i], Sum, name);
                }
                System.Console.WriteLine(name);
                return Sum * (++GlobalCount);
            }
        }
    
    }


}
