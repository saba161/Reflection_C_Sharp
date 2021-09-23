using System;
using System.Linq;
using System.Reflection;

namespace Examples
{
    class Program
    {
        public class Person
        {
            private int x { get; set; }
            private int y { get; set; }

            private void Const()
            {
                Console.WriteLine("saba + sa");
            }
        }

        class B : Person { }

        static void Main(string[] args)
        {
            Type type = typeof(Person);

            object person = CreateClass<Person>.CreateClassObject(new Person());

            var members = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (PropertyInfo item in members)
            {
                if (item.Name == "x") 
                {
                    item.SetValue(person, 5);
                    Console.WriteLine(item.GetValue(person));
                }
            }
        }
    }
}