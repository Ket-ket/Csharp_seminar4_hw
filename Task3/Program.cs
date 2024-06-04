// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

// Например:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

using System.IO.Compression;

int ReadInt(string text){
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreatedArr(int size, int leftRange, int rightRenge){
    int[] arr = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i++){
        arr[i] = rand.Next(leftRange, rightRenge);
    }
    return arr;
}

void PrintArr(int[] array){
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] ChangeArr(int[] arr){
    int[] array = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++){
        array[i] = arr[arr.Length - 1 -i]; 
    }
    return array;
}

int size = ReadInt("Введите длину массива: ");
int[] newArray = CreatedArr(size, 0, 10);
PrintArr(newArray);
int[] finalArr = ChangeArr(newArray);
PrintArr(finalArr);
