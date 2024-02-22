using System;

class Large
{
    static void Main()
    {
        int [] arr = new int [5];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]=(i+1)*(i+1);
        }
        Console.WriteLine("Array: ");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
        int large = arr[0];
        for (int i=1; i<arr.Length; i++)
        {
            if (arr[i] > large)
            {
                large = arr[i];
            }
        }
        Console.WriteLine("Largest number in the array: " + large);
    }
}