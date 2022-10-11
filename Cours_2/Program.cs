using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Cours_2
{
    internal class Program
    {
        static string GetVowels(params string[] input)
        {
            if (input == null || input.Length ==0 )
            {
                return string.Empty;
            }
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }
        /*
        public (string, string, string, int) GetPersonalInfo(string id)
        {
            PersonInfo per = PersonInfo.RetrieveInfoByld(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

        var person = GetPersonalInfo("111111111");
        Console.WriteLine($"{person.Item1}{person.Item3}:age={person.Item4});

    public (string FName, string MName, string LName, int Age) GetPersonalInfo(string id)
        {
            PersonInfo per = Person.Info.RetrieveInfoByld(id);
            return (per.FirstName, per.MiddleName, per.LastName, per.Age);
        }

        var person = GetPersonalInfo("111111");
        Console.WriteLine($"{person.Item1}{person.Item3}:age={person.Age});
            */
        static void Main(string[] args)
        {
            string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
            Console.WriteLine($"Vowels from array:'{fromArray}");

            string fromMultipleArguments = GetVowels("apple", "banana", "pear");
            Console.WriteLine($"Vowels from multiple arguments:'{fromMultipleArguments}'");

            string fromNull = GetVowels(null);
            Console.WriteLine($"Vowels from null:'{fromNull}");

            string fromNoValue = GetVowels();
            Console.WriteLine($"Vowems from no value:'{fromNoValue}");

            int variable_1 = 245;//value type
            Console.WriteLine("In Main, variable_1={0}", variable_1);
            ModifyValue(variable_1);
            Console.WriteLine("Back in Main, variable_1={0}", variable_1);

            double d = 24.3;
            int a;
            a = (int)d;
            Console.WriteLine(a);


            var age = 25;
            Console.WriteLine("var holds TYPE:{0} | VAL:{1}", age.GetType(), age);
            var name = "Pramit";
            Console.WriteLine("var holds TYPE:{0} | VAL:{1}", name.GetType(), name);

            string.IsNullOrWhiteSpace("zz");


            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";

            r1.calculateArea(new int[] { 100, 200 });
            r1.getColor();

            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] { 100, 200, 300 });
            t1.getColor();
        }
        static void ModifyValue(int variable_1)//only a copy of variable-1 is reveived
        {
            variable_1 = 30;
            Console.WriteLine("In ModifyValue, variable_1={0}", variable_1);
            return; // we donot return the updated value of variable_1
        }

    }
}
