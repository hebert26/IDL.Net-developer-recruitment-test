using System.Collections.Generic;

namespace TechnicalTests
{
    public class Sorter
    {
        public IList<T> BubbleSort<T>(IList<T> list)
        {
            return BubbleSort(list, Comparer<T>.Default);
        }

        public IList<T> BubbleSort<T>(IList<T> list, IComparer<T> comparer)
        {
            //TODO:HG Handle exception when list is null
            bool incomplete = true;
            while (incomplete)
            {
                incomplete = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    T x = list[i];
                    T y = list[i + 1];
                    if (comparer.Compare(x, y) > 0)
                    {
                        list[i] = y;
                        list[i + 1] = x;
                        incomplete = true;
                    }
                }
            }

            return list;
        }
    }
}