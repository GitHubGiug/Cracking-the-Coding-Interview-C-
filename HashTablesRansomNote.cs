using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    class Program
    {
        

        static void Main(String[] args)
        {
            int m = 6;
            int n = 5;
            string[] magazine = new string[] { "two", "times", "three", "is", "not", "four"};
            string[] ransom = new string[] { "two", "times","two", "is", "four" };

            if (Result(magazine, ransom))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
            
            Console.ReadKey();
        }



        public static bool Result(string[] magazine, string[] ransom)
        {

            var magDictionary = ConvertToDictionary(magazine);
            var ransomDictionary = ConvertToDictionary(ransom);

            foreach(var word in ransomDictionary)
            {
                if (!magDictionary.ContainsKey(word.Key))
                    return false;
                else
                {
                    magDictionary[word.Key]=((magDictionary[word.Key])-ransomDictionary[word.Key]);
                    if (magDictionary[word.Key] < 0)
                        return false;
                }
            }
            return true;
        }


        public static Dictionary<string,int> ConvertToDictionary(string[] array)
        {
            var dict = new Dictionary<string, int>();

            foreach (string word in array)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word]++;
                }
            }
            return dict;
        }
    }

}
