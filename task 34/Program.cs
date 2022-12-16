//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int LENGTH = 5;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 999;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");

int count = 0;
for( int i = 0; i < massive.Length; i++)
{
    if ((massive[i] % 2) == 0)
    {
        count++;
        
    }
    
}
Console.WriteLine(count);

