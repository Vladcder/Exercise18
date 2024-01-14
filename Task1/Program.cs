using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

             
            string myString=Console.ReadLine();
            if (IsCorrect(myString))
            {
                Console.WriteLine("Скобки расcтавлены правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены неправильно");
            }
            Console.ReadKey();

        }


        private static bool IsCorrect(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(')');
                        break;
                    case '[':
                        stack.Push(']');
                        break;
                    case '{':
                        stack.Push('}');
                        break;
                    default:
                        if (stack.Count != 0 && c == stack.Peek())
                        {
                            stack.Pop();
                        }
                        else if (c == ')' || c == ']' || c == '}')
                        {
                            return false;
                        }
                        break;
                }
            }
          
            return stack.Count == 0;
        }
    }
}
