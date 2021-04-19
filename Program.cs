using System;
using System.Linq;
using System.Collections.Generic;


namespace aandltask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>{};
            string insert = "gamer";

            while(insert != "stop"){
                Console.WriteLine("Enter word to add");
                insert = Console.ReadLine();
                if(insert == "stop"){
                    break;
                }
                words.Add(insert);
            }

            for(int i = words.Count()-1; i >= 0; i--){
                Console.Write(words[i] + " ");
            }
        }
    }
}
