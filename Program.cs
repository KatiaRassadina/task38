// Задайте массив вещественных чисел. Найдите разницу между макс и мин элементами массива
int[] array = new int[10];
void newArray(int[]array)
{for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
}
}
void PrintArray(int[]array)
{for (int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]}");
    if (i < (array.Length)) Console.Write($", "); }
Console.WriteLine(" ");};
newArray(array);
PrintArray(array);
int min = array[0];
int max = array[0];
for (int i=0; i<array.Length; i++)
{if (array[i] < min)
{
    min = array[i];
}
else if (array[i]> max)
{
    max = array[i];
}
}
Console.WriteLine("The diffrence between max and min is " +(max-min));