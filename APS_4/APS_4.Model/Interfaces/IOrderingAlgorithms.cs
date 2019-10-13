using APS_4.Model.Entities;

namespace APS_4.Model.Interfaces
{
    public interface IOrderingAlgorithms
    {
        OrderingEntity BubbleSort(OrderingEntity entity);
        OrderingEntity SelectionSort(OrderingEntity entity);
        OrderingEntity InsertionSort(OrderingEntity entity);
        int MergeSort(int[] mainArray, int begin, int end);
        OrderingEntity QuickSort(OrderingEntity entity);
        OrderingEntity ShellSort(OrderingEntity entity);
    }
}
