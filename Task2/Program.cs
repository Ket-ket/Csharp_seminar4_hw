// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// Например:
// [344 452 341 125] => 2


int ReadInt(string text){
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreatedArr(int size, int leftRange, int rightRange){
    int[] Array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        Array[i] = rand.Next(leftRange, rightRange);
    }
    return Array;
}

void PrintArr(int[] array){
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int EvenNum(int[] array){
    int count = 0;
    foreach(int num in array){
        if(num % 2 == 0)
            count++;
    }
    return count;
}

int size = ReadInt("Введите размер массива: ");
int[] arr = CreatedArr(size, 100, 1000);
PrintArr(arr);
int countEvenNum = EvenNum(arr);
Console.WriteLine($"Количество четных чисел в массиве: {countEvenNum}");