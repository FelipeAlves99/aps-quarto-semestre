using APS_4.Model.Entities;
using APS_4.Model.Interfaces;
using System;
using System.Diagnostics;

namespace APS_4.Model.Module
{
    public class OrderingAlgorithms : IOrderingAlgorithms
    {
        private OrderingEntity _entity = null;

        public OrderingAlgorithms()
        {
            _entity = new OrderingEntity();
        }

        public OrderingEntity BubbleSort(OrderingEntity entity)
        {
            var time = Stopwatch.StartNew();

            #region Bubble

            int arraySize = entity.NumberList.Length;

            for (int i = arraySize - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    _entity.Moves++;
                    if (entity.NumberList[j] > entity.NumberList[j + 1])
                    {
                        int aux = entity.NumberList[j];
                        entity.NumberList[j] = entity.NumberList[j + 1];
                        entity.NumberList[j + 1] = aux;
                    }
                }
            }

            #endregion

            time.Stop();
            _entity.NumberList = entity.NumberList;
            _entity.Time = time.ElapsedMilliseconds;
            return _entity;
        }

        public OrderingEntity InsertionSort(OrderingEntity entity)
        {
            var time = Stopwatch.StartNew();
            
            #region Insertion

            if (entity.NumberList.Length <= 1)
            {
                entity.Moves = 0;
                entity.Time = time.ElapsedMilliseconds;
                return entity;
            }

            int j, key;

            for (int i = 1; i < entity.NumberList.Length; i++)
            {
                j = i - 1;
                key = entity.NumberList[i];
                entity.Moves++;

                while (j >= 0 && key < entity.NumberList[j])
                {
                    entity.NumberList[j + 1] = entity.NumberList[j];
                    j--;
                    entity.NumberList[j + 1] = key;
                    _entity.Moves++;
                }
            }

            #endregion

            time.Stop();
            _entity.Time = time.ElapsedMilliseconds;
            _entity.NumberList = entity.NumberList;

            return _entity;
        }

        public int MergeSort(int[] mainArray, int begin, int end)
        {
            int middle;
            if (end > begin)
            {
                middle = (end + begin) / 2;
                MergeSort(mainArray, begin, middle);
                MergeSort(mainArray, (middle + 1), end);
                Merge(mainArray, begin, middle, end);
                return _entity.Moves;
            }
            return _entity.Moves;
        }

        private void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
                _entity.Moves++;
            }
        }

        public int QuickSort(int[] mainArray, int begin, int end)
        {
            int low, high, middle, pivot, aux;
            low = begin;
            high = end;
            middle = (int)((low + high) / 2);

            pivot = mainArray[middle];

            while (low <= high)
            {
                while (mainArray[low] < pivot)
                    low++;
                while (mainArray[high] > pivot)
                    high--;
                if (low < high)
                {
                    aux = mainArray[low];
                    mainArray[low++] = mainArray[high];
                    mainArray[high--] = aux;
                    _entity.Moves++;
                }
                else
                {
                    if (low == high)
                    {
                        low++;
                        high--;
                    }
                }
            }

            if (high > begin)
                QuickSort(mainArray, begin, high);
            if (low < end)
                QuickSort(mainArray, low, end);

            return _entity.Moves;
        }

        public OrderingEntity SelectionSort(OrderingEntity entity)
        {
            var time = Stopwatch.StartNew();
            int minimum, aux;

            #region Selection

            for (int i = 0; i < entity.NumberList.Length - 1; i++)
            {
                minimum = i;

                for (int j = i; j < entity.NumberList.Length; j++)
                {
                    _entity.Moves++;
                    if (entity.NumberList[j] < entity.NumberList[minimum])
                        minimum = j;
                }

                if (minimum != i)
                {
                    aux = entity.NumberList[minimum];
                    entity.NumberList[minimum] = entity.NumberList[i];
                    entity.NumberList[i] = aux;
                    _entity.Moves++;
                }
            }

            #endregion

            time.Stop();
            _entity.Time = time.ElapsedMilliseconds;
            _entity.NumberList = entity.NumberList;

            return _entity;
        }

        public OrderingEntity ShellSort(OrderingEntity entity)
        {
            var time = Stopwatch.StartNew();

            #region Shell

            int arraySize = entity.NumberList.Length;
            int j, value;
            int gap = 1;

            do
            {
                gap = 3 * gap + 1;
            } while (gap < arraySize);

            do
            {
                gap /= 3;
                for (int i = gap; i < arraySize; i++)
                {
                    value = entity.NumberList[i];
                    j = i - gap;

                    while (j >= 0 && value < entity.NumberList[j])
                    {
                        entity.NumberList[j + gap] = entity.NumberList[j];
                        j -= gap;
                        _entity.Moves++;
                    }
                    entity.NumberList[j + gap] = value;
                    _entity.Moves++;
                }
                _entity.Moves++;
            } while (gap > 1);

            #endregion

            time.Stop();
            _entity.Time = time.ElapsedMilliseconds;
            _entity.NumberList = entity.NumberList;

            return _entity;
        }
    }
}
