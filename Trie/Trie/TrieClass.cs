using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trie
{

    class TrieNode
    {
        public int value;
        public int count;
        public TrieNode[] child = new TrieNode[26];
        public bool hasChild = false;

        public TrieNode()
        {
            this.count = 0;
            this.value = 0;
        }

        public void AddChild()
        {
            this.child = new TrieNode[26];
            this.hasChild = true;
            for (int i = 0; i < 26; i++)
            {
                child[i] = new TrieNode();
            }
        }
    }

    class Trie
    {
        TrieNode Head;
        int sum = 0, tempsum = 0;
 
        public Trie()
        {
            Head = new TrieNode();
            Head.value = -1;
        }

        public void AddString(string target)
        {
            int length = target.Length;
            TrieNode node = Head;
            for (int i = 0; i < length; i++)
            {
                int current = (int)target[i] - 65;
                if (!node.hasChild)
                {
                    node.AddChild();
                }
                node.child[current].count++;
                node.child[current].value = current + 1;
                node = node.child[current];
            }
        }

        public int Calculate()
        {
            TrieTraversal(Head, 0, 1);
            return sum;
        }

        private void TrieTraversal(TrieNode current, int sum, int count)
        {
            if (current.value == -1) tempsum = 0;
            if (current.count != 0)
            {
                tempsum += current.value;
                //System.Console.WriteLine("level " + depth + ": value = " + current.value + " count = " + current.count);
            }
            if (current.hasChild)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (current.child[i] != null) TrieTraversal(current.child[i], tempsum, count);
                }
            }
            else
            {
                sum += tempsum * count;
                tempsum = 0;
                count++;
                return;
            }
        }
    }
}
