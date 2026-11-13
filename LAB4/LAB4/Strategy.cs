using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public interface Searchingstrategy
    {
        int Search(int[] array, int t);
    }
    public class Linearsearch: Searchingstrategy
    {
        public int Search(int[] array, int t)
        {
            Console.WriteLine(" Линейный поиск.");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == t)
                {
                    return i; 
                }
            }
            return -1; 
        }

    }

    public class Binarysearch : Searchingstrategy
    {

        public int Search(int[] array, int target)
        {
            Console.WriteLine("Бинарный поиск ");
            int l = 0;
            int r = array.Length - 1;

            while (l <= r)
            {
                int mid = l+ (r - l) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    l = mid + 1;
                else
                    r = mid - 1;
            }
            return -1;
        }

    }
    public class  Searcher //контекст
    {
        private Searchingstrategy s;
        public void Setstrategy(Searchingstrategy strategy)
        {
            s = strategy;
        }

        public int FindEl(int[] array, int t)
        {
            return s.Search(array, t);
        }
    }

}
