using APS_4.Model.Entities;
using APS_4.Model.Interfaces;
using System;

namespace APS_4.Model.Module
{
    public class OrderingAlgorithms : IOrderingAlgorithms
    {
        public OrderingEntity BubbleSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }

        public OrderingEntity InsertionSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }

        public OrderingEntity MergeSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }

        public OrderingEntity QuickSort(OrderingEntity entity)
        {
            throw new NotImplementedException();
        }

        public OrderingEntity SelectionSort(OrderingEntity entity)
        {
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
