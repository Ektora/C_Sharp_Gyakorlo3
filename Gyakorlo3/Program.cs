
class Gyakorlo3
{

    public static void Main(string[] args)
    {

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

}
