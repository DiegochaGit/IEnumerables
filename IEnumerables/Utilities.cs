namespace IEnumerables;

public class Utilities
{
    // Methods for Exercise 33

    public static void GenerateMatrixA(List<List<int>> matrixA, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            matrixA.Add(new List<int>());
            for (int j = 0; j < n; j++)
            {
                matrixA[i].Add((i + 1) * j);
            }
        }
    }

    public static void GenerateMatrixB(List<List<int>> matrixB, int n, int p)
    {
        for (int i = 0; i < n; i++)
        {
            matrixB.Add(new List<int>());
            for (int j = 0; j < p; j++)
            {
                matrixB[i].Add((j + 1) * i);
            }
        }
    }

    public static string ShowMatrix(List<List<int>> matrix, int rows, int cols)
    {
        var output = String.Empty;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                output += matrix[i][j] + "\t";
            }
            output += "\n";
        }
        return output;
    }

    public static List<List<int>> MultiplyMatrices(List<List<int>> matrix1, List<List<int>> matrix2)
    {
        int rows1 = matrix1.Count;
        int cols1 = matrix1[0].Count;
        int rows2 = matrix2.Count;
        int cols2 = matrix2[0].Count;
        if (cols1 != rows2)
        {
            throw new ArgumentException("Matrices are not compatible for multiplication.");
        }
        List<List<int>> product = new List<List<int>>();
        for (int i = 0; i < rows1; i++)
        {
            product.Add(new List<int>());
            for (int j = 0; j < cols2; j++)
            {
                product[i].Add(0);
                for (int k = 0; k < cols1; k++)
                {
                    product[i][j] += matrix1[i][k] * matrix2[k][j];
                }
            }
        }
        return product;
    }


    // Methods for Exercise 34

    public static void GenerateFullMatrix(List<List<int>> matrixOriginal, int n)
    {
        for (int i = 0; i < n; i++)
        {
            matrixOriginal.Add(new List<int>());
            for (int j = 0; j < n; j++)
            {
                matrixOriginal[i].Add(i + 2 * j);
            }
        }
    }

    public static string ShowFullMatrix(List<List<int>> matrixOriginal, int n)
    {
        var output = String.Empty;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                output += matrixOriginal[i][j] + "\t";
            }
            output += "\n";
        }
        return output;
    }

    public static void GenerateHourglassMatrix(List<List<int>> matrixOriginal, List<List<int>> matrixHourglass, int n)
    {
        for (int i = 0; i < n; i++)
        {
            matrixHourglass.Add(new List<int>());
            for (int j = 0; j < n; j++)
            {
                matrixHourglass[i].Add(-1);
            }
        }
        for (int i = 0; i < n / 2 + 1; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                matrixHourglass[i][j] = matrixOriginal[i][j];
                matrixHourglass[n - i - 1][j] = matrixOriginal[n - i - 1][j];
            }
        }
    }

    public static string ShowHourglassMatrix(List<List<int>> matrixHourglass, int n)
    {
        var output = String.Empty;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrixHourglass[i][j] == -1)
                {
                    output += "\t";
                }
                else
                {
                    output += matrixHourglass[i][j] + "\t";
                }
            }
            output += "\n";
        }
        return output;
    }


    // Methods for Exercise 35
    public static LinkedList<int> GetPrimeFactors(int number)
    {
        LinkedList<int> factors = new LinkedList<int>();
        int divisor = 2;
        while (number > 1)
        {
            if (number % divisor == 0)
            {
                factors.AddLast(divisor);
                number /= divisor;
            }
            else
            {
                divisor++;
            }
        }
        return factors;
    }

    public static string ShowPrimeFactors(LinkedList<int> factors, int number)
    {
        var output = number + " = ";
        foreach (int factor in factors)
        {
            if (factor.Equals(factors.Last.Value))
            {
                output += factor;
            }
            else
            {
                output += factor + " x ";
            }
        }
        return output;
    }

}
