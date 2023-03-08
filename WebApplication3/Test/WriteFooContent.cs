using System;
using System.Linq;
using System.Reflection;

namespace WebApplication3.Test
{
    public class WriteFooContent
    {
        public void WriteLine(IHaveFoo instance)
        {
            Console.WriteLine("Instance : " + instance.Foo);
        }

        public TypeInfo[] GetAllFoos()
        {
            return GetType().Assembly.DefinedTypes.Where(t => typeof(IHaveFoo).IsAssignableFrom(t)).ToArray();
        }
    }
}