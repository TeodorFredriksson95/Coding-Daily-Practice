// See https://aka.ms/new-console-template for more information
// using Dictionaries; // Removed because the namespace does not exist or is not referenced
using System.Data.Common;

Console.WriteLine("Hello, World!");



// --------------------- DICTIONARY PRACTICE ------------------------------
var dictionaryPractice = new DictionaryPractice();

dictionaryPractice.Run();

Dictionary<int, string> gameCompanies = new();

dictionaryPractice.InsertDictionaryValue(gameCompanies, 5, "Nintendo");


// Instantiate of BoxEqualityComparer which implements custom equality check
BoxEqualityComparer boxComparer = new BoxEqualityComparer();

// Initialize a dictionary instance with the BoxEqualityComparer as argument
Dictionary<Box, string> boxDictionary = new Dictionary<Box, string>(boxComparer);

// Add a few boxes to the dictionary
DictionaryHelperFunctions.AddBox(boxDictionary, new Box(1, 2, 3), "box number one");
DictionaryHelperFunctions.AddBox(boxDictionary, new Box(10, 15, 2), "box number two");

// Use a Box object with using the same dimensions as its key, which already exist. Should trigger ArgumentException error
DictionaryHelperFunctions.AddBox(boxDictionary, new Box(1, 2, 3), "box number three");


//--------------------- ALTERNATIVE KEY DICTIONARY LOOKUP ------------------------------

// Create a couple of people. Consider a factory.
Person person1 = new Person() {
    Id = 123, Age = 29, Name = "Teo", Occupation = "Wannabe software dev"
};
Person person2 = new Person() {
Id = 999, Age = 22, Name = "Erica", Occupation = "Journalist"
};

//Create Person dictionary with custom comparer
PersonEqualityComparer personComparer = new PersonEqualityComparer();
Dictionary<Person, string> personDict = new Dictionary<Person, string>(personComparer)
{
    {
        person1, "Text for person one here"
    },
    {
        person2, "Text for person two here"
    }

};

// Declare and assign alternative lookup.
// We're using int as the type for the key we're gonna look into the dictionary with, instead of a Person object
var altLookup = personDict.GetAlternateLookup<int>();
System.Console.WriteLine(altLookup[999]); // Prints the value of the element at index 999 - "Text for person two here"


//--------------------- ARRAYS ------------------------------
FirstArrayTest firstArrayTest = new FirstArrayTest();

System.Console.WriteLine(firstArrayTest.nullableCars[1]?.Make ?? "No car found at index 0");
// "Dereference of a possible null reference - 'nullableArray may be null here'" warning from compilor. The warning originates from
// the fact that we have stated that the nullableArray itself may in fact be null by declaring it like so: Public Car[]? nullableArray;

try
{
    // We declared the array as nullable. The compiler warns us about this. This gives us an opportunity to inspect the array declaration before execution.
    // If we were to inspect the array we would see that it is intialized to null, which will throw an error.
    System.Console.WriteLine(firstArrayTest.nullableArray[0]);
}
catch (NullReferenceException e)
{
    System.Console.WriteLine("Trying to print a value from an array that is declared as null itself will throw a NullReferenceException. Message: " + e.Message);
}

    // If we are certain that the array is not null, we could use the null-forgiving operator ! to suppress all null-related warnings for this specific array
    System.Console.WriteLine(firstArrayTest.nullableArrayNotNullPromise![0].Make);
    System.Console.WriteLine(firstArrayTest.nullableArrayNotNullPromise![1].Make);



// -------------------ONE DIMENSIONAL ARRAYS ----------------------------

// var OneDimensionalArrayOne = new OneDimensionalArrays();

OneDimensionalArrays.Main(); // Runs the Main method of OneDimensionalArrays. Could be quite useful for keeping program.cs a bit cleaner
OneDimensionalArrays.DisplayArray(firstArrayTest.nullableArrayNotNullPromise, "DisplayArray Method Prints: ");

MultiDimensionalArrays.Main();