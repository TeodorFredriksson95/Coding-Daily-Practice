
// Specify two classes: Box will serve as an object key used in a dictionary,'
// and BoxEqualityComparer will be used to define how equality evaluation is performed for Box dictionary objects
using System.Runtime.CompilerServices;

public class Box
{
    public int Length { get; }
    public int Width { get; }
    public int Height { get; }

    // Box fields are initialized only through the constructor
    public Box(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public override string ToString() => $"Box({Length}, {Width}, {Height})";


}

public static class DictionaryHelperFunctions
{
    // Helper method: Add Box to dictionary
    public static void AddBox(Dictionary<Box, string> boxDictionary, Box box, string name)
    {
        try
        {
            boxDictionary.Add(box, name);
        }
        catch (ArgumentException e)
        {
            System.Console.WriteLine($"Unable to add {box}: {e.Message}");
        }
    }
}

// Modified Equality comparison method for the object: Box
public class BoxEqualityComparer : IEqualityComparer<Box>
{
    public bool Equals(Box? box1, Box? box2)
    {
        if (ReferenceEquals(box1, box2)) return true;


        if (box1 is null || box2 is null)
        {
            Console.WriteLine("One of the boxes is null.");
            return false;
        }
        return box1.Length == box2.Length &&
                   box1.Width == box2.Width &&
                   box1.Height == box2.Height;

    }

    public int GetHashCode(Box box) => box.Height ^ box.Length ^ box.Width;
}