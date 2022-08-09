/ Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();

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

int[] arraySum(int[] array)
{
if (array.Length % 2 == 0)
{
int[] newArray = new int[array.Length / 2];
for (int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}
return newArray;
}
else
{
int[] newArray = new int[array.Length / 2 + 1];
for (int i = 0; i < array.Length / 2; i++)
{
newArray[i] = array[i] * array[array.Length - 1 - i];
}
newArray[newArray.Length - 1] = array[array.Length / 2];
return newArray;
}
}

int[] array = CreateArrayRnd(6, 1, 5);

PrintArray(array);
Console.WriteLine();
int[] count = arraySum(array);

PrintArray(count);