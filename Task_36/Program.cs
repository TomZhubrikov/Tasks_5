// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Функция заполнения массива.
void InputArray(int[] array) {
    int i;
    for (i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 1000);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// Функция вывода суммы элементов, стоящих на нечётных позициях.
void OutputResult(int[] array) {
    int i, sum = 0;
    for (i = 1; i < array.Length; i += 2) {
        sum = sum + array[i];
    }
    Console.WriteLine($"Sum of elements in odd position -> {sum}");
}

int n; 
Console.Clear();
Console.Write("Enter size of array -> n = ");
n = int.Parse(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
OutputResult(array);
