using System;
using System.Linq.Expressions;

namespace SimpleLog
{
    public static class Logger
    {
        public static readonly string DefaultFormat = "Name: {0}\nValue: {1}\n";
        public static string LoggingFormat = DefaultFormat;
        public static void Log<T>(Expression<Func<T>> variable, object valueIfNeeded = null)
        {
            var name = variable.Body.ToString();
            var value = valueIfNeeded ?? variable.Compile().Invoke();

            Console.Write(LoggingFormat, name, value);
        }
    }
}
