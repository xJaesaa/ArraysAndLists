using System;
using System.Linq;
using System.Collections.Generic;


namespace aandltask_2_1
{
    class Program
    {
        static void Main_2_1(string[] args)
        {
            List<int> number = new List<int>{13, 15, 23, 81, 34};
            Console.WriteLine("Enter a number");

            string insertStr = Console.ReadLine();
            int insert = int.Parse(insertStr);

            if(number.Contains(insert)){
                Console.WriteLine("number already exists");
            }
            else{
                Console.WriteLine("Fresh new number pog");
            }
        }
    }
}
