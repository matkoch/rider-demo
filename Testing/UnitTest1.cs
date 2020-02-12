using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Testing
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            A.M();
        }

        [Fact]
        public void Test2()
        {
            B.M();
        }
    }

    public class A
    {
        public static void M ()
        {
            if (new Random().Next(0, 1) == 2)
                throw new Exception();
        }
    }

    public class B
    {
        public static void M ()
        {
            IEnumerable<string> GetPeople()
                => new[] {"Tim", "Josh", "Chris"};

            IEnumerable<string> FilterPeople(IEnumerable<string> people)
                => people.Where(x => x.Length <= 4);

            void PrintPeople(IEnumerable<string> people)
            {
                people.ToList().ForEach(PrintPerson);
            }

            void PrintPerson(string s1) => Console.WriteLine(s1);

            PrintPeople(FilterPeople(GetPeople()));

            var enumerable = new[] {"Chris", "Maarten", "Matt"};
            PrintPeople(enumerable);
        }
    }
}