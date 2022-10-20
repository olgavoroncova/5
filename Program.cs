// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*int[] array = new int[5];
Random rand = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(count);
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



/*/int[] array = new int[4];
Random rand = new Random();
int res = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(5, 10);
}
for (int i = 1; i < array.Length; i += 2)
{
    res = array[i] + res;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов array[1], [3] = {res}");
*/
// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] array = { 3, 7, 22, 2, 78 };

double count = 0;
double max = 0;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
count = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {count}");

