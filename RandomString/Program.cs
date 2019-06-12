using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class Program
    {
        static void Main(string[] args)
        {
            const string charSet = "QWERTYUIOPASDFGHJKLZXCVBNM";
            var r = new Random();
            var s = "";
            var length = r.Next(8, 13);
            while (length-- > 0)
            {
                s += charSet[r.Next(charSet.Length)];
            }
            Console.WriteLine($"Your random string is: {s}");
        }
    }
}
