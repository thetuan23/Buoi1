using System;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 9, 10, 27, 38, 43, 82 };
        int target = 27;
        int index = BinarySearch(arr, target);
        if (index != -1)
        {
            Console.WriteLine("Phần tử được tìm thấy ở chỉ số: " + index);
        }
        else
        {
            Console.WriteLine("Phần tử không tồn tại trong mảng");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (array[middle] == target)
            {
                return middle;
            }
            if (array[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}
