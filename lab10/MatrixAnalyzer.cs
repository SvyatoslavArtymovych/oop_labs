using System;
using System.Collections.Generic;

class MatrixAnalyzer
{
    private readonly int[,] matrix;
    private readonly int rows, cols;

    public MatrixAnalyzer(int[,] matrix)
    {
        this.matrix = matrix;
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
    }

    public int CountRowsWithoutZeros()
    {
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero) count++;
        }
        return count;
    }

    public int? MaxDuplicateNumber()
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int val in matrix)
        {
            if (freq.ContainsKey(val))
                freq[val]++;
            else
                freq[val] = 1;
        }

        int? max = null;
        foreach (var pair in freq)
        {
            if (pair.Value > 1)
            {
                if (max == null || pair.Key > max)
                    max = pair.Key;
            }
        }

        return max;
    }
    public int SumOfNegativeElements()
    {
        int sum = 0;
        foreach (int val in matrix)
        {
            if (val < 0)
                sum += val;
        }
        return sum;
    }

}