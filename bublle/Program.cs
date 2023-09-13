using System;

class BubbleSort
{
    static void Main()
    {
        Console.Write("Введіть кількість чисел: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        // Зчитуємо числа з консолі та заповнюємо масив
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Викликаємо функцію сортування бульбашкою
        BubbleSortArray(numbers);

        Console.WriteLine("Відсортований масив:");

        // Виводимо відсортований масив
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Обмін значень
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
