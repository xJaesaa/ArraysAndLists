using System;
using System.Linq;
using System.Collections.Generic;


namespace aandltask_2_2
{
    class Program
    {
        static void Main_2_2(string[] args)
        {
            List<int> number2 = new List<int>{13, 15, 23, 82, 15, 23, 34, 23, 13, 15};
            Console.WriteLine("Enter a number");

            string insertStr = Console.ReadLine();
            int insert = int.Parse(insertStr);

            var total = number2.Count(n => n == insert);
            Console.WriteLine("-----------");
		    Console.WriteLine(insert + " occurs " + total + " times");
        }
    }
}
