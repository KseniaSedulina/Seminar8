//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* int[,] streamline = new int[3, 4];

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
FillArrayRandom(streamline);
PrintArray(streamline);
SortArray(streamline);
Console.WriteLine();
PrintArray(streamline);
*/
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*Console.Write ("Input a - the number or rows:" );
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input b - the number or columns:" );
int b = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[a,b];

void array(int a, int b)
    {
    int i,j;
    Random rand = new Random();
    for (i = 0; i < a; i++)
        {
        for (j = 0; j < b; j++)
            {
            randomArray[i,j] = rand.Next(1,9);
            }
        }
    }

void PrintArray(int[,] array)
{
     int i,j;
     for (i = 0; i < array.GetLength(0); i++)
        {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
            {
            Console.Write($"{array[i,j]}");
            }
            Console.WriteLine(); 
        }
}

array(a,b);
Console.WriteLine ("It is your initial array");
PrintArray(randomArray);

int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
    {
    sum += array[i,j];
    }
return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
if (sum > SumLine(randomArray, i))
     {
     sum = SumLine(randomArray, i);
     minSum = i+1;
    }
}
Console.WriteLine("Row with the lowest sum is :");
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int m = InputNumbers("Input the numbers of first matrix rows: ");
int n = InputNumbers("Input the numbers of first matrix columns and second matrix rows: ");
int p = InputNumbers("Input the numbers of second matrix columns: ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine();
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine();
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine("Multiplication first and second matrix is: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next();
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
