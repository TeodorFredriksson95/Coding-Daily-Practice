
public class FirstArrayTest
{
    // Array declarations in C# can be nullable or non-nullable.
    // type?[] arrayName; // non nullable array of nullable element types.    
    // type[]? arrayName; // nullable array of non-nullable element types.
    // type?[]? arrayName; // nullable array of nullable element types.


    // Let's create a few arrays to demonstrate the difference in nullability vs non-nullability and how to it with different types and values.

    // type?[] arrayName;
    public Car?[] nullableCars; // We declare that the nullableCars array itself is non-nullable, but the individual elements it contains can be either null, or, valid references of type Car
    public Car[]? nullableArray; // The array itself can be null, but the individual elements it contains cannot be null. This means that if the array is not null, it will always contain valid Car objects.
    public Car?[]? nullableArrayAndElements; // Both the array and the elements can be null.

    public Car[]? nullableArrayNotNullPromise = new Car[2];
    public FirstArrayTest()
    {
        // Elements of the array can be null, but the array itself cannot be null.
        nullableCars = new Car[5];
        nullableCars[0] = new Car("Honda");

        nullableArray = null; // The array itself is null, meaning it does not point to any valid memory location.

        nullableArrayNotNullPromise[0] = new Car("Mazda");
        nullableArrayNotNullPromise[1] = new Car("Maserati");

    }


    // Uninitialized elements of arrays are set to their default values.

    int[] uninitializedIntArray = new int[5]; // All elements will be initialized to 0. (default value for int)
    bool[] uninitializedBoolArray = new bool[5]; // All elements will be initialized to false. (default value for bool)
    string[] uninitializedStringArray = new string[5]; // All elements will be initialized to null. (default value for string)
    char[] uninitializedCharArray = new char[5]; // All elements will be initialized to '\0'. (default value for char)

}

// Private class Car
public class Car
{
    public string Make { get; }
    public Car(string make)
    {
        Make = make;
    }

    public override string ToString() => $"{Make}";
}




