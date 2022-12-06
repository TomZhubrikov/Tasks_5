// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Функция заполнения массива.
void InputArray(double[] array) {
    int i;
    for (i = 0; i < array.Length; i++) {
        array[i] = new Random().NextDouble();
    }
    Console.WriteLine($"[{string.Join("; ", array)}]");
}

// Функция вывода разницы между максимальным и минимальным элементов массива.
void OutputResult(double[] array) {
    int i = 0;
    double max, min;
    max = array[i];
    min = array[i];
    for (i = 1; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Sum of elements in odd position -> {max - min}");
}

int n; 
Console.Clear();
Console.Write("Enter size of array -> n = ");
n = int.Parse(Console.ReadLine());
double[] array = new double[n];

InputArray(array);
OutputResult(array);