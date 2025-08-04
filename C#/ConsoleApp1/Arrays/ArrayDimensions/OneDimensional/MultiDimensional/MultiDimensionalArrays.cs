

public class MultiDimensionalArrays
{

    // Declare a jagged array
    int[][] jaggedArray1 = new int[3][]; // Declared but uninitialized


    public static void Main()
    {
        int[,] array2DDeclaration = new int[3, 4]; // Declaration of two-dimensional array with 3 rows and 4 columns.
        int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } }; // Object initialize values of array

        int[,,] array3DDeclaration = new int[4, 2, 3]; //Declaration of three-dimensional array.
        int[,,] array3DInitializaion = { { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9, } } };

        for (int i = 0; i < array3DInitializaion.Rank; i++)
        {
            System.Console.WriteLine($"3d array rank nr: {i}");
        }

        // How to access array elements of a 2D array
        System.Console.WriteLine(array2DInitialization[0, 0]); //Outputs 1.
        System.Console.WriteLine(array2DInitialization[1, 1]); //Outputs 4
        System.Console.WriteLine(array2DInitialization[3, 0]); //Outputs 7  


        //Being lazy and curious here. Wanted to declare the singleDimensionArray as static as well as consolditate logs from testing in one file. Will probably lead to confusion down the line as to why I placed it here, disobeying the folder structure.
        var oneDArray = OneDimensionalArrays.singleDimensionalArray;
        System.Console.WriteLine(oneDArray[0]); //Outputs 0. The array is uninitialized meaning the elements use their 0-bit pattern default value. For integers, that's 0.

        //Assign a value to the single-dimensional array.
        oneDArray[0] = 5;
        System.Console.WriteLine(oneDArray[0]); //Outputs 5 this time.


        // Set the values of the first array in the jagged array structure declared in MultiDimensionalArrays class
        var jaggedArrays = new MultiDimensionalArrays();
        jaggedArrays.jaggedArray1[0] = [1, 2, 3, 4]; //Collection expression used to initialize array
        System.Console.Write("values from jaggedArray1[0]: ");
        foreach (var item in jaggedArrays.jaggedArray1[0])
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();

        // Get the total count of elements or the length of a given dimension
        var allLength = array3DInitializaion.Length;
        var total = 1;
        for (int i = 0; i < array3DInitializaion.Rank; i++)
        {
            //What does total really represent? If array3D[0] contains 3 elements then calc would be 1*3 = 3. If array3D[1] contains 4 elements then
            // the calc would be 3*4 = 12. It makes no sense that it should end up as 12 as told in docs.

            //Ok, so multi-dimensional arrays must still contain the same amount of elements in each dimension. so, array3D[1] cannot contain
            // an arbitrary amount of elements. If array3D[0] contains 3 elements, we can expect array3D[1] to contain 3 elements.

            //Ok so i probably missunderstood 3d arrays at its core. A multi-dimensional array has the following structure:
            // Depth --> rows --> columns
            // So in order to get the length of a 3-dimensional array you can think:
            // Depth*Rows*Columns = Length, or for a N-dimensional array:
            // Length = GetLength(0) * GetLength(1) * ... * GetLength(N-1)
            total *= array3DInitializaion.GetLength(i);
            System.Console.WriteLine($"variable 'total' value: " + total);
        }

        System.Console.WriteLine($"{allLength} equals {total}");

        // It helps me to visualize multidimensional arrays like this:
        // Say we have a 2D array like so:
        int[,] intArray2D = { { 1, 2 }, { 8, 9 }, { 15, 18 } };

        // We can consider each inner bracket as part of a row in a 'column/row' table
        // We can flatten the 2D array to visualize it

        // {1, 2} --> represents row 0
        // {8, 9} --> represents row 1
        // {15, 18} --> represents row 2

        // We can determine how many dimensions exist within an array by the amount of indicies we need to use to access an element.
        // If we were to retrieve the value 8 we would have to use the following:
        // intArray2D[1, 0] --> outputs 8

        //Likewise, if we had a 3-dimensional array we would access a value like so:
        // intArray3D[a, b, c]

        // In the 2D array we can think of intArray2D[0,1] as intArray2D[row0, column1].
        // Furthermore we can think of it as intArray2D[dimension0, dimension1].

    }

}