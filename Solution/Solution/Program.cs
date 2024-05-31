using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        int inputCounter = 0;

        string name = null; 

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (inputCounter < stringsCount)
        {
            string input = Console.ReadLine();

            // provide a possibility to break the loop.

            if (input == "exit")
            {
                break;
            }

            string[] items = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            if (items[0] == null)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                phoneBook[items[0]] = items[1];
                inputCounter++;
            }
        }

            while ((name = Console.ReadLine()) != null && name.Length > 0)
            {
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phoneBook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
    }
}

