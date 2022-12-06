// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Функция заполнения массива
void InputArray(int[] array) {
    int i;
    for (i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// Функция вывода кол-ва чётных чисел
void OutputResult(int[] array) {
    int i, count = 0;
    for (i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"The number of even numbers in the array -> {count}");
}

int n; 
Console.Clear();
Console.Write("Enter size of array -> n = ");
n = int.Parse(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
OutputResult(array);
