int[,] array = new int[,]
{
    {1, 2, 3, 4 },
    {5, 6, 7,8 },
    {9, 1, 2, 3 },
    {4, 5, 6, 7 }
};

int count = 0;

for (int i = 0; i < array.GetLength(0), i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[ i, j]% 2 == 0)
        {
            count++;
        }
    }
}

Console.WriteLine(count);
/*
7 9 6 7 8 7   9 8 9

7 8 8 16 -8 3 3 19 -19 6
 
*/
