using APS_4.Model.Entities;
using APS_4.Model.Interfaces;
using System;

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
            throw new NotImplementedException();
        }

        public OrderingEntity InsertionSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
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

        public OrderingEntity QuickSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }

        public OrderingEntity SelectionSort(OrderingEntity entity)
        {
            entity.Moves = 0;
            entity.Time = 0;
            var tempo = System.Diagnostics.Stopwatch.StartNew();
            int minimo, aux;

            for (int i = 0; i < entity.NumberList.Length - 1; i++)
            {
                minimo = i;

                for (int j = i; j < entity.NumberList.Length; j++)
                {
                    entity.Moves++;
                    if (entity.NumberList[j] < entity.NumberList[minimo])
                        minimo = j;
                }

                if (minimo != i)
                {
                    aux = entity.NumberList[minimo];
                    entity.NumberList[minimo] = entity.NumberList[i];
                    entity.NumberList[i] = aux;
                }
                entity.Moves++;
            }

            tempo.Stop();
            entity.Time = tempo.ElapsedMilliseconds;

            return entity;
        }

        public OrderingEntity ShellSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
