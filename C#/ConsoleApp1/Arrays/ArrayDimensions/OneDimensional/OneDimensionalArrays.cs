


using Microsoft.VisualBasic;

public class OneDimensionalArrays
{
    // We've made the DisplayArray method take a generic argument of type <T>. Important to remember to either adjust the code of the method 
    // to account for this, or, we have to override the ToString method of whatever type we expect to input, because in a generic instance like this,
    // we rely on generic behavior, which ToString() handles efficiently. Up to us to specify how we to handle this generic value.
    public static void DisplayArray<T>(T[] arr, string prefix = "") => Console.WriteLine(prefix + string.Join(" ", arr));

    // Change the array by reversing its elements.
    static void ChangeArray(string[] arr) => Array.Reverse(arr);

    static void ChangeArrayElements(string[] arr)
    {
        // Change the value of the first three array elements.
        arr[0] = "Mon";
        arr[1] = "Wed";
        arr[2] = "Fri";
    }

    // Declare a single-dimensional array of 5 integers
    public static int[] singleDimensionalArray = new int[5];

    // Declare a single-dimensional array and set the values of the elements
    public static int[] singleDimensionalArray2 = [1, 2, 3, 4, 5];
    public OneDimensionalArrays()
    {

    }
    public static void Main()
    {
        // Declare and initialize an array.
        string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
        // Display the array elements.
        DisplayArray(weekDays);
        Console.WriteLine();

        // Reverse the array.
        ChangeArray(weekDays);
        // Display the array again to verify that it stays reversed.
        Console.WriteLine("Array weekDays after the call to ChangeArray:");
        DisplayArray(weekDays);
        Console.WriteLine();

        // Assign new values to individual array elements.
        ChangeArrayElements(weekDays);
        // Display the array again to verify that it has changed.
        Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
        DisplayArray(weekDays);
    }
}