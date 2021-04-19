using System;
using System.Linq;
using System.Collections.Generic;


namespace aandltask_1_1
{
    class Program
    {
        static void Main_1_1(string[] args)
        {
            string[] names = {"hello jaesa", "hello taylor", "hello ben", "hello josh", "hello reilly", "its goblin time boys lets go"};
            
            foreach(var item in names){
                Console.WriteLine(item.ToString());;
            }
        }
    }
}
