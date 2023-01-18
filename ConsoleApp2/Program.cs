using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {        
            var loop = 1;
            var inputList = new List<int>();
            var visitedIndex=new List<int>();
            int curIndex;
            string strInput;

            while (loop == 1)
            {
                inputList.Clear();
                Console.WriteLine("Enter Input List");
                strInput = Console.ReadLine();
                if (strInput.Length > 0)
                {
                    inputList = strInput.Split(",").Select(int.Parse).ToList();
                }

                visitedIndex.Clear();
                curIndex = 0;
                for (int i = 0; i < inputList.Count; i++)
                {
                    curIndex = inputList[curIndex];
                    if (curIndex < inputList.Count)
                    {
                        if (!visitedIndex.Contains(curIndex))
                        {
                            visitedIndex.Add(curIndex);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (visitedIndex.Count == inputList.Count)
                {
                    Console.WriteLine("List is circular");
                }
                else
                {
                    Console.WriteLine("List is not circular");
                }
                Console.WriteLine("Press ESC to exit, any other key to continue");
                if(Console.ReadKey().Key==ConsoleKey.Escape)
                {
                    loop = 0;
                }
            }
        }
    }
}
