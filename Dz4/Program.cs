
class SpiralArray
{
    static void Main()
    {
        int[,] arr = new int[4, 4];
        int num = 1;
        int minCol = 0;
        int maxCol = 3;
        int minRow = 0;
        int maxRow = 3;

        while (num <= 16)
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                arr[minRow, i] = num;
                num++;
            }

            for (int i = minRow + 1; i <= maxRow; i++)
            {
                arr[i, maxCol] = num;
                num++;
            }

            for (int i = maxCol - 1; i >= minCol; i--)
            {
                arr[maxRow, i] = num;
                num++;
            }

            for (int i = maxRow - 1; i >= minRow + 1; i--)
            {
                arr[i, minCol] = num;
                num++;
            }

            minCol++;
            minRow++;
            maxCol--;
            maxRow--;
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        
    }
}

