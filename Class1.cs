namespace MergeSort
{
    public static class Merge<T> where T : IComparable
    {
        static T[] MergeMethod(T[] a, T[] b)
        {
            T[] result = new T[a.Length + b.Length];
            int aindex = 0;
            int bindex = 0;
            int resindex = 0;
            while (resindex != result.Length)
            {
                if (aindex == a.Length)
                {
                    result[resindex] = b[bindex];
                    bindex++;
                    resindex++;
                    continue;
                }
                if (bindex == b.Length)
                {
                    result[resindex] = a[aindex];
                    aindex++;
                    resindex++;
                    continue;
                }
                if (a[aindex].CompareTo(b[bindex]) == -1 || a[aindex].CompareTo(b[bindex]) == 0)
                {
                    result[resindex] = a[aindex];
                    aindex++;
                    resindex++;
                    continue;
                }

                if (bindex < b.Length && a[aindex].CompareTo(b[bindex]) == 1)
                {
                    result[resindex] = b[bindex];
                    bindex++;
                    resindex++;
                    continue;
                }
            }
            return result;
        }
        public static T[] Sort(T[] elements)
        {
            if (elements.Length == 1)
            {
                T[] myArray = { elements[0] };
                return myArray;
            }
            int mid = elements.Length / 2;
            T[] left = new T[mid];
            T[] right = new T[elements.Length - mid];
            for (int i = 0; i < mid; i++)
            {
                left[i] = elements[i];
            }
            for (int j = mid; j < elements.Length; j++)
            {
                right[j - mid] = elements[j];
            }
            left = Sort(left);
            right = Sort(right);
            return MergeMethod(left, right);
        }
    }
}
