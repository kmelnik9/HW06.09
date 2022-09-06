//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Degree(int A, int B)
{
    int deg = 1;
   for (int i=1; i<=B; i++)
   {
    deg = deg*A;
   }
    return deg;
}

System.Console.WriteLine(Degree(2, 4));

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int N)
{
    int sum = 0;
   for (int i=1; N>1; i++)
   {
    sum = sum + N%10;
    N = N/10;
   }
    return sum;
}

System.Console.WriteLine(GetSum(9012));

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] RandArray()
{
    int[] array = new int[8];
    for(int i=0; i<array.Length; i++)
    {
    int random = new Random().Next(100);
    array[i]=random;
    }
    return array;
}

System.Console.WriteLine($"[{string.Join(", ", RandArray())}]");
