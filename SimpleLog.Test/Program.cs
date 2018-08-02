using System;
using static SimpleLog.Logger;

namespace SimpleLog.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Log(() => "holy");
            Log(() => $"holy{"shit"}");

            var a = "ho!";
            Log(() => a);
            Log(() => a.ToString());
            Log(() => "a" + "b");

            Console.Read();
        }
    }
}
