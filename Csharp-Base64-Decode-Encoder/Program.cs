using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Base64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.WriteLine("Decode[1]\nEncode[2]");
                int process = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (process == 1)
                {
                    Console.WriteLine("Pleas Enter Encode Text: ");
                    string text = Console.ReadLine();
                    Console.Clear();
                    var y = Convert.FromBase64String(text);
                    var output = Encoding.UTF8.GetString(y);
                    Console.WriteLine(output);
                    Thread.Sleep(10000);
                    Console.Clear();    
                }


                if (process == 2)
                {
                    Console.WriteLine("Pleas Enter Decode Text: ");
                    string text = Console.ReadLine();
                    Console.Clear();
                    var x = Encoding.UTF8.GetBytes(text);
                    var output = Convert.ToBase64String(x);
                    Console.WriteLine(output);
                    Thread.Sleep(10000);
                    Console.Clear();
                }

            }
        }
    }
}
