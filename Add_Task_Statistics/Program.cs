// Функция заполнения массива
void InputArray(int[] array) {
    int i;
    for (i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 32);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// Функция вывода результата.
void OutputResult(int[] array) {
    int i, countEven = 0, countOdd = 0;
    for (i = 0; i < array.Length; i++) {
        if (array[i] % 2 != 0) {
            Console.Write($"{array[i]} ");
            countOdd++;
        }
    }
    Console.WriteLine();
    for (i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            Console.Write($"{array[i]} ");
            countEven++;
        }
    }
    Console.WriteLine();
    if (countEven >= countOdd) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}

int n; 
Console.Clear();
Console.Write("Enter size of array -> n = ");
n = int.Parse(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
OutputResult(array);
