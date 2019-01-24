using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnome_Sort
{
    class GnomeSort
    {
        public int[] Ascending(int[] arr)
        {
            int pos = 0;

            while (pos < arr.Length)
            {
                //Comparing
                if (pos == 0 || arr[pos - 1] <= arr[pos])
                {
                    pos++;
                }
                else
                {
                    //Swapping
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
            //returning sorted array
            return arr;
        }
        public int[] Decending(int[] arr)
        {
            int pos = 0;
            while (pos < arr.Length)
            {
                //Comparing
                if (pos == 0 || arr[pos - 1] >= arr[pos])
                {
                    pos++;
                }
                else
                {
                    //Swapping
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
            //returning sorted array
            return arr;
        }
    }
}

