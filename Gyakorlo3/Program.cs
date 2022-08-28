
class Gyakorlo3
{

    public static void Main(string[] args)
    {
        // 4-es minta keresése két dimenziós tömbben
        /*
        int[,] tomb = new int[,] {
            {4,1,4,2,5},
            {4,6,3,2,1},
            {4,1,6,2,1},
            {1,2,3,6,5},
            {2,3,2,5,6} };
        for(int i = 0; i < tomb.GetLength(0); i++)
        {
            for(int j = 0; j < tomb.GetLength(1); j++)
            {
                Console.Write(tomb[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Van 4-es minta a kétdimenziós tömbben: " + isConsecutiveFour(tomb));
        */

        /* Két mátrix összeadása
        double[,] a = { {2,4,7}, {1,5,3} };
        double[,] b = { { 1, 7, -2 }, { 4, 2, 1 } };
        double[,] result = addMatrix(a, b);
        if(result != null)
        {
            tombKiIras(result);
        }
        else
        {
            Console.WriteLine("A két mátrix nem adható össze");
        }
        */

        // Két mátrix összeszorása
        double[,] b = { { 3, 4}, { 1, 5} };
        double[,] a = { { 2, 4, 7 }, { 1, 5, 3 } };
        double[,] result = multiplyMatrix(a, b);
        if (result != null)
        {
            tombKiIras(result);
        }
        else
        {
            Console.WriteLine("A két mátrix nem szorozható össze");
        }
    }

    public static bool isConsecutiveFour(int[,] values)
    {
        for(int i = 0; i< values.GetLength(0) - 2; i++)
        {
            for(int j = 0; j < values.GetLength(1) - 2; j++)
            {
                if(values[i,j] == values[i,j+1] && values[i,j] == values[i,j+2] && values[i,j] == values[i,j+3])
                    return true;
                if (values[i, j] == values[i + 1, j] && values[i, j] == values[i + 2, j] && values[i, j] == values[i + 3, j])
                    return true;
                if (values[i, j] == values[i + 1, j + 1] && values[i, j] == values[i + 2, j + 2] && values[i, j] == values[i + 3, j + 3])
                    return true;
            }
        }
        return false;
    }

    public static double[,] addMatrix(double[,] a, double[,] b)
    {
        if(a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
        {
            double[,] result = new double[a.GetLength(0), a.GetLength(1)];
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j= 0; j < a.GetLength(1); j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        return null;
    }

    public static double[,] multiplyMatrix(double[,] a, double[,] b)
    {
        double[,] eredmeny = null;
        double osszeg = 0;
        int i, j, k;
        if (a.GetLength(1) == b.GetLength(0))
        {
            eredmeny = new double[a.GetLength(0), b.GetLength(1)];
            for(i = 0; i < a.GetLength(0); i++)
            {
                for( j = 0; j < b.GetLength(1); j++)
                {
                    osszeg = 0;
                    for (k = 0; k < a.GetLength(0); k++)
                    {
                        osszeg += a[i, k] * b[k, j];
                    }
                    eredmeny[i, j] = osszeg;
                }
            }
        }
        else if (b.GetLength(1) == a.GetLength(0))
        {
            eredmeny = new double[b.GetLength(0), a.GetLength(1)];
            for (i = 0; i < b.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    osszeg = 0;
                    for (k = 0; k < b.GetLength(0); k++)
                    {
                        osszeg += b[i, k] * a[k, j];
                    }
                    eredmeny[i, j] = osszeg;
                }
            }
        }
        return eredmeny;
    }

    public static void tombKiIras(double[,] tomb)
    {
        for (int i = 0; i < tomb.GetLength(0); i++)
        {
            for (int j = 0; j < tomb.GetLength(1); j++)
            {
                Console.Write(tomb[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}
