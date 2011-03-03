using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem79
{
    class Problem79
    {
        LinkedList<char> ll = new LinkedList<char>();

        public bool AddInput(string input)
        {
            if (ll.Count == 0)
            {
                foreach (char c in input.ToCharArray())
                {
                    ll.AddLast(c);
                }
                return true;
            }
            else if(ll.Contains(input[0]) && !ll.Contains(input[2]) && !ll.Contains(input[1]))
            {
                LinkedListNode<char> first = ll.Find(input[0]);
                ll.AddAfter(first, input[2]);
                ll.AddAfter(first, input[1]);
                return true;
            }
            else if (ll.Contains(input[2]) && !ll.Contains(input[0]) && !ll.Contains(input[1]))
            {
                LinkedListNode<char> first = ll.Find(input[2]);
                ll.AddBefore(first, input[2]);
                ll.AddBefore(first, input[1]);
                return true;
            }
            else
            {
                LinkedListNode<char> node = ll.Find(input[0]);
                bool found1 = false;
                bool found2 = false;
                while (node != ll.Last && node != null && !found1 && !found2)
                {
                    node = node.Next;
                    if (!found1)
                    {
                        if (node.Value == input[1])
                        {
                            found1 = true;
                        }
                    }
                    else
                    {
                        if (node.Value == input[2])
                        {
                            found2 = true;
                        }
                    }

                }
                return found1 && found2;
            }
            /*else if(ll.Contains(input[1]))
            {
                LinkedListNode<char> node = ll.Find(input[1]);
                ll.AddAfter(node, input[2]);
                ll.AddBefore(node, input[0]);
            }*/
        }
        public bool check(string input)
        {
            if (ll.Contains(input[0]))
            {
                LinkedListNode<char> node = ll.Find(input[0]);
                bool found1 = false;
                bool found2 = false;
                while (node != ll.Last && node != null && !found1 && !found2)
                {
                    node = node.Next;
                    if (!found1)
                    {
                        if (node.Value == input[1])
                        {
                            found1 = true;
                        }
                    }
                    else
                    {
                        if (node.Value == input[2])
                        {
                            found2 = true;
                        }
                    }

                }
                return found1 && found2;
            }
            else return false;
            
        }
        static void Main(string[] args)
        {
            Problem79 prog = new Problem79();
            FileInfo file = new FileInfo("keylog.txt");
            StreamReader sr = new StreamReader(file.FullName);
            List<string> lines = new List<string>();
            while( sr.Peek() >= 0 )
            {
                string input = sr.ReadLine();
                // we dont need duplicates
                if (!lines.Contains(input))
                {
                    lines.Add(input);
                }
            }
            //lines.Sort();
            List<string> failed = new List<string>();
            foreach (string line in lines)
            {
                if (!prog.AddInput(line))
                {
                    failed.Add(line);
                }

            }
            foreach (string line in failed)
            {
                if (prog.check(line))
                {
                    Console.WriteLine(line);
                }

            }
            
            Console.ReadKey();
        }
    }
}
