// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];

void FillMatrix(int[,,] matr)
{
    int count = 10;
    int i = new int();
    int j = new int();
    int k = new int();
    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (j = 0; j < matr.GetLength(1); j++)
        {
            for (k = 0; k < matr.GetLength(2); k++)
            {
                count = count + i + j + k;
                matr[i, j, k] = count;
                Console.Write($" {matr[i, j, k]} "+"("+$"{i}, " + $"{k}, " + $"{j} " + ")");
            }
            Console.WriteLine();
        }
    }
}

FillMatrix(array);
