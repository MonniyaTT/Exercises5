using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readwords = new StreamReader("../../words.txt");
            string lineWords = readwords.ReadToEnd();
            Console.WriteLine(lineWords);

            Exercise1(lineWords);
            Exercise2(lineWords);
        }

        private static void Exercise2(string lineWords)
        {
            string wordsLong = "";
            int count = 0;
            var words = lineWords.Split(' ');

            foreach (var item in words)
            {
                if (item.Length > count)
                {
                    count = item.Length;
                    wordsLong = item;
                }
            }
            Console.WriteLine("The longest word : " + wordsLong);

        }

        private static void Exercise1(string lineWords)
        {
            var words = lineWords.Split(' ');
            int countWords = words.Length;
            Console.WriteLine("The number of words : " + countWords);
        }


    }
}
