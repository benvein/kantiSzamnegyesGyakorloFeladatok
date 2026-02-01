int[,] matrix = new int[3, 3];

int n = 3;
int m = 3;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine("[{0},{1}]: ",i,j);
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("[{0},{1}] = {2}\t", i, j, matrix[i,j]);
    }
    Console.WriteLine();
}

int allCount = matrix[1, 1];
int countA = matrix[0,0];
int countB = matrix[0, 2];
int countC = matrix[2, 0];
int countD = matrix[2, 2];

if(allCount != (countA + countB + countC + countD))
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine($"[{countA}, {countB}, {countC}, {countD}]");
}