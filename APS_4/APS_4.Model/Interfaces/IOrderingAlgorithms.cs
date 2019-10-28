using APS_4.Model.Entities;

namespace APS_4.Model.Interfaces
{
    public interface IOrderingAlgorithms
    {
        OrderingEntity BubbleSort(OrderingEntity entity);
        OrderingEntity SelectionSort(OrderingEntity entity);
        OrderingEntity InsertionSort(OrderingEntity entity);
        int MergeSort(int[] mainArray, int begin, int end);
        int QuickSort(int[] mainArray, int begin, int end);
        OrderingEntity ShellSort(OrderingEntity entity);
    }
}
