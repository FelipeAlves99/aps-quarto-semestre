using APS_4.Model.Entities;

namespace APS_4.Model.Interfaces
{
    public interface IOrderingAlgorithms
    {
        OrderingEntity BubbleSort(int[] mainArray);
        OrderingEntity SelectionSort(int[] mainArray);
        OrderingEntity InsertionSort(int[] mainArray);
        int MergeSort(int[] mainArray, int begin, int end);
        int QuickSort(int[] mainArray, int begin, int end);
        OrderingEntity ShellSort(int[] mainArray);
    }
}
