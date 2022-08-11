// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = CreateArrayRnd(6, 1, 5);
Console.Clear();
PrintArray(array);
Console.WriteLine();
int[] count = ArraySum(array);
PrintArray(count);

int[] CreateArrayRnd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < array.Length - 1)
            Console.Write(array[i] + ",");
        else
            Console.Write(array[i] + "]");
    }
}

//Удалось избавиться от повторяющихся сущностей, но думаю, что можно еще сократить.

int[] ArraySum(int[] array)
{
    //вводим переключатель для длины нового массива (хранение результатов умножения) он увеличивает длину, если изначальный массив имеет нечетное еоличество элементов
    int onOff=0;
    if (array.Length % 2 == 0) onOff = 0;
    else onOff = 1;
        
    int[] newArray = new int[array.Length / 2 + onOff];

    //здесь в новый массив записываем результаты умножения пар элементов исходного массива
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    //тут, если маасив был с нечетным количеством элементов записываем в конец "средний" элемент
    if (onOff == 1) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}