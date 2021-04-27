using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class SortAlgorithms
    {
        public static void Test()
        {
            var arr = new int[] { 5, 8, 1, 4, 10, 45, 12, 26, 47, 89, 23, 24 };
            SortAlgorithms.PrintArray(arr);

            //BubleSort(arr);
            //SelectionSort(arr);
            //InsertionSort(arr);
            //HeapSort heapSort = new HeapSort();
            //heapSort.Sort(arr);
            QuickSort quickSort = new QuickSort();
            quickSort.Sort(arr);

            SortAlgorithms.PrintArray(arr);
        }
        static void BubleSort(int[] arr)
        {
            int temp;
            PrintArray(arr);
            for (int k = 0; k < arr.Length - 1; k++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }
            PrintArray(arr);
        }

        static void SelectionSort(int[] arr)
        {
            PrintArray(arr);
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                int minIndex = i;
                for (int k = i; k < arrLength; k++)
                {
                    if (arr[k] < arr[minIndex])
                    {
                        minIndex = k;
                    }
                }

                int minValue = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = minValue;
            }
            PrintArray(arr);
        }

        static void InsertionSort(int[] arr)
        {
            PrintArray(arr);
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int prevIndex = i - 1;
                while (prevIndex >= 0 && arr[prevIndex] > current)
                {
                    arr[prevIndex + 1] = arr[prevIndex];
                    prevIndex--;
                }
                arr[prevIndex + 1] = current;
            }
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }

        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }

    public class HeapSort
    {
        public void Sort(int[] arr)
        {
            var length = arr.Length;

            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, length, i);
            }

            for (int i = length - 1; i >= 0; i--)
            {
                SortAlgorithms.Swap(ref arr[i], ref arr[0]);
                Heapify(arr, i, 0);
            }
        }
        private void Heapify(int[] arr, int length, int currentIndex)
        {
            int largestIndex = currentIndex;

            int leftIndex = largestIndex * 2 + 1;
            int rightIndex = largestIndex * 2 + 2;

            if (leftIndex < length && arr[leftIndex] > arr[largestIndex])
            {
                largestIndex = leftIndex;
            }

            if (rightIndex < length && arr[rightIndex] > arr[largestIndex])
            {
                largestIndex = rightIndex;
            }

            if (currentIndex != largestIndex)
            {
                SortAlgorithms.Swap(ref arr[currentIndex], ref arr[largestIndex]);
                Heapify(arr, length, largestIndex);
            }
        }
    }

    public class MergeSort
    {
        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                sort(arr, l, m);
                sort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        private void merge(int[] arr, int l, int m, int r)
        {
            int sizeL = m - l + 1;
            int sizeR = r - m;

            int[] arrL = new int[sizeL];
            int[] arrR = new int[sizeR];

            int indexL, indexR;

            for (indexL = 0; indexL < sizeL; indexL++)
            {
                arrL[indexL] = arr[l + indexL];
            }

            for (indexR = 0; indexR < sizeR; indexR++)
            {
                arrR[indexR] = arr[m + 1 + indexR];
            }

            indexL = indexR = 0;
            int indexMain = l;

            while (indexL < sizeL && indexR < sizeR)
            {
                if (arrL[indexL] <= arrR[indexR])
                {
                    arr[indexMain] = arrL[indexL];
                    indexL++;
                }
                else
                {
                    arr[indexMain] = arrR[indexR];
                    indexR++;
                }
                indexMain++;
            }

            while (indexL < sizeL)
            {
                arr[indexMain] = arrL[indexL];
                indexL++;
                indexMain++;
            }

            while (indexR < sizeR)
            {
                arr[indexMain] = arrR[indexR];
                indexMain++;
                indexR++;
            }
        }        
    }

    public class QuickSort
    {
        public void Sort(int[] arr)
        {
            var length = arr.Length;

            if (length > 0)
            {
                ProccessSort(arr, 0, length - 1);
            }
        }

        private void ProccessSort(int[] arr, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int pivot = Partition(arr, lowIndex, highIndex);
                ProccessSort(arr, lowIndex, pivot - 1);
                ProccessSort(arr, pivot + 1, highIndex);
            }
        }

        private int Partition(int[] arr, int lowIndex, int highIndex)
        {
            var pivotValue = arr[highIndex];
            var lastSmallerIndex = -1;

            for (int i = 0; i < highIndex; i++)
            {
                if (arr[i] < pivotValue)
                {
                    lastSmallerIndex++;

                    if (lastSmallerIndex != i)
                    {
                        SortAlgorithms.Swap(ref arr[i], ref arr[lastSmallerIndex]);
                    }
                }
            }

            SortAlgorithms.Swap(ref arr[highIndex], ref arr[lastSmallerIndex + 1]);

            return lastSmallerIndex + 1;
        }
    }

}
