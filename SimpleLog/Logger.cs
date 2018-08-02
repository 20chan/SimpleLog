using System;
using System.Linq.Expressions;

namespace SimpleLog
{
    public static class Logger
    {
        public static void Log<T>(Expression<Func<T>> variable, object valueIfNeeded = null)
        {
            var name = variable.Body.ToString();
            var value = valueIfNeeded ?? variable.Compile().Invoke();

            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Value: {0}", value);
        }
    }
}
