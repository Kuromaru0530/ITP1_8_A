using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_8_A
{
    class Program
    {
        static void Main()
        {
            string Line = Console.ReadLine();
            List<string> lines = new List<string>();

            foreach(char c in Line)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        lines.Add(c.ToString().ToLower());
                    }
                    else if (char.IsLower(c))
                    {
                        lines.Add(c.ToString().ToUpper());
                    }
                }
                else lines.Add(c.ToString());
            }
            string Ans = string.Join("", lines.ToArray());
            Console.WriteLine(Ans);
        }
    }
}