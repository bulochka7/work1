// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}

int[,] CreateNewArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 1; j < array.GetLength(1); j++)
            {
                for(int x=j;x>0;x--)
                if (array[i,x] > array[i,x-1])
                {
                    
                    temp = array[i,x];
                    array[i,x] = array[i,x-1];
                    array[i,x-1] = temp;
                    
                }                   
            }            
        }
    return array;
}

int[,] array=CreateArray(5,5,1,10);
PrintArray(array);
Console.WriteLine();
CreateNewArray(array);
PrintArray(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}

void SumMax(int[,] array)
{   
    int iMax=0; 
    int sum=0;
    int sumMax=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
                sum+=array[i,j];
            }
        if(sumMax <sum)
        {   
            sumMax=sum;
            iMax=i;
        }
    }
    
    Console.WriteLine($"{sumMax} {iMax}");
}

int[,] array=CreateArray(5,5,1,10);
PrintArray(array);
Console.WriteLine();
SumMax(array);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}
int[,] QuadMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(1),array2.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {    {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
                for (int n = 0; n < array1.GetLength(1); n++)
                {
                    array[i, j] += array1[i, n] * array2[n, j];
                }
            }
        }
    }
    return array;
}

int[,] array1=CreateArray(2,2,1,3);
PrintArray(array1);
Console.WriteLine();
int[,] array2=CreateArray(2,2,1,3);
PrintArray(array2);
Console.WriteLine();
int[,] array= QuadMatrix(array1,array2);
PrintArray(array);

*/


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateArray1(int rows, int columns,int n, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns,n];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for(int z=0;z<n; z++) 
                {
                    array[i,j,z] = new Random().Next(minValue, maxValue + 1);
                } 
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for(int z = 0;z < array.GetLength(2); z++)  
            {    Console.Write(array[i,j,z]);
                if(z<array.GetLength(2)-1)
                Console.Write(", ");
            }    
        if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}


int[,,] array= CreateArray1(2,2,2,10,99);
PrintArray(array);