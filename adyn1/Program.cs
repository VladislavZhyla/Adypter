using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adyn1
{
   
    public static class ArraySetConverter
    {
        public static HashSet<T> ArrayToSet<T>(T[] array)
        {
            return new HashSet<T>(array);
        }

        public static T[] SetToArray<T>(HashSet<T> set)
        {
            return set.ToArray();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 3, 4, 5 };
            
            HashSet<int> set = ArraySetConverter.ArrayToSet(array);
            Console.WriteLine("Set: " + string.Join(", ", set));

            int[] newArray = ArraySetConverter.SetToArray(set);
            Console.WriteLine("Array: " + string.Join(", ", newArray));
            Console.ReadKey();
        }
    }
}
    
