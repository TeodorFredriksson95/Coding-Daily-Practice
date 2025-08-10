

public class BasicSyntax
{
    // Declared - not yet assigned or initialized. It holds no value and no memory is allocated,
    //  it only contains null.
    string words;

    // Initializing a variable means assigning it an initial value;
    int unAssignedInt;
    int assignedInt = 5;

    // Variable is assigned a value and is instantiated, but the elements of the array remain uninitialized.
    // The keyword 'new' suggest we are creating an instance of a string array.
    string[] wordArray = new string[5];
    

    public static float ResistanceCalculator(int voltage, int current)
    {
        return voltage / current;
    }

    public static void Main()
    {

        // When reading an initialized variable, the compiler reads from right to left. In essence, this means that
        // the expression to the right is calculated before it is assigned to the variable. See example below;
        float resistance = ResistanceCalculator(5, 4);
        System.Console.WriteLine("Resistance: " + resistance);

        // In the above example, ResistanceCalculator(5,4); is being evaluated before it is assigned to the 
        // variable 'resistance'.
    }



    // Invocation means to invoke 

}