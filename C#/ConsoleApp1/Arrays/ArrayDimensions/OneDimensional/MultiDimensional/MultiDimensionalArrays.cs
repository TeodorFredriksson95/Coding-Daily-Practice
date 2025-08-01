

public class MultiDimensionalArrays
{


    public static void Main()
    {
        int[,] array2DDeclaration = new int[3, 4]; // Declaration of two-dimensional array with 3 rows and 4 columns.
        int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; // Object initialize values of array

        int[,,] array3DDeclaration = new int[4, 2, 3]; //Declaration of three-dimensional array.
        int[,,] array3DInitializaion = { { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };

        for (int i = 0; i < array3DInitializaion.Rank; i++)
        {
            System.Console.WriteLine($"3d array rank nr: {i}");
        }
    }

}