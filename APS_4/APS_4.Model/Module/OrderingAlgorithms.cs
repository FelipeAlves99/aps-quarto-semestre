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

        public int MergeSort(int[] mainArray, int inicio, int fim)
        {
            int meio;
            if (fim > inicio)
            {
                meio = (fim + inicio) / 2;
                MergeSort(mainArray, inicio, meio);
                MergeSort(mainArray, (meio + 1), fim);
                Merge(mainArray, inicio, meio, fim);
                return _entity.Moves;
            }
            return _entity.Moves;
        }

        private void Merge(int[] input, int esquerda, int meio, int direita)
        {
            int[] arrayEsquerda = new int[meio - esquerda + 1];
            int[] arrayDireita = new int[direita - meio];

            Array.Copy(input, esquerda, arrayEsquerda, 0, meio - esquerda + 1);
            Array.Copy(input, meio + 1, arrayDireita, 0, direita - meio);

            int i = 0;
            int j = 0;
            for (int k = esquerda; k < direita + 1; k++)
            {
                if (i == arrayEsquerda.Length)
                {
                    input[k] = arrayDireita[j];
                    j++;
                }
                else if (j == arrayDireita.Length)
                {
                    input[k] = arrayEsquerda[i];
                    i++;
                }
                else if (arrayEsquerda[i] <= arrayDireita[j])
                {
                    input[k] = arrayEsquerda[i];
                    i++;
                }
                else
                {
                    input[k] = arrayDireita[j];
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
