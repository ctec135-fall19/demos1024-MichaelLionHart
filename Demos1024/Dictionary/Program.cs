using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            Dictionary<string, Student> studentDictionary =
                new Dictionary<string, Student>();

            // initialize (two different initialization methods shown here)
            studentDictionary.Add("Mike", new Student("Mike1"));
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            // traversal
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            foreach(Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
        }
    }
}
