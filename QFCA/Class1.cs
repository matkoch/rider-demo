using System;
using System.Collections.Generic;
using System.Linq;

namespace QFCA
{
    public class Class1
    {
        public void A()
        {
//            IEnumerable list = default(IEnumerable);

            var paragraph =
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";

            var containsOnlyLetters = !paragraph.Any(x => !char.IsLetter(x));
        }


        public IEnumerable<string> B (IEnumerable<string> collection)
        {
            foreach (var str in collection)
            {
                if (string.IsNullOrEmpty(str))
                    continue;

                yield return str;
            }
        }

        private void M(string[] args)
        {
            foreach (var s in args)
            {
                foreach (var s1 in args)
                {
                    foreach (var s2 in args)
                    {
                        foreach (var s3 in args)
                        {
                        }
                    }
                }
            }
        }

        private void N(string[] args)
        {
            foreach (var s in args){}


            foreach (var s in args){}
            foreach (var s in args){}
            foreach (var s in args){}
            foreach (var s in args){}
        }
    }
}