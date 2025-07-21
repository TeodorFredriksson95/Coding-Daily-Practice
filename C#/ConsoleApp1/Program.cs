// See https://aka.ms/new-console-template for more information
// using Dictionaries; // Removed because the namespace does not exist or is not referenced

Console.WriteLine("Hello, World!");

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

