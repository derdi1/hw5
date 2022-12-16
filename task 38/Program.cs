// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100;

int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");


int max = massive.Max();
int min = massive.Min(); 
int diff = 0;
for (int i = 0; i < massive.Length; i++)
{
    if(massive[i] > max)
    {
        max = massive[i];
    }
    if(massive[i] < min)
    {
        min = massive[i];
    }
    diff = max - min;
}

Console.WriteLine(diff);




