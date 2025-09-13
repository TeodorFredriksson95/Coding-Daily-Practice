
using System.Runtime.CompilerServices;
using System.Xml;

public class BaseCharacter
{
    public int stamina { get; set; }
    public int strength;
    public string className;

    public static void Main()
    {
        var baseChar = new BaseCharacter();
        System.Console.WriteLine("Base character stamina: " + baseChar.stamina); // 0
        System.Console.WriteLine("Base character strength: " + baseChar.strength); // 0
        System.Console.WriteLine("Base character class name: " + baseChar.className); // Base character class name:

        string anotherClassName = baseChar.className; //Null reference exception

        System.Console.WriteLine("Another class name: " + anotherClassName); //Null ref error

        //en textsträng
        string ferrisString = "Ferri is cool";
        string secondString = "Teo is so awesome";

        string joinedString;

        string[] exArray = ["1", "2", "3"];
        string secondStringLol = "text to be added";

        string secondJoinedString = String.Join("/", ferrisString, secondString);
        System.Console.WriteLine(secondJoinedString);

        // // joina textsträngen med en annan
        // joinedString = String.Join(ferrisString, secondString);
        // System.Console.WriteLine("joined string: " + joinedString);

        // vid 3e bokstaven i andra strängen


        Console.WriteLine(MakeLine(0, 5, ", "));
        System.Console.WriteLine(JoinBase(", ", new string[]{"1", "2", "3", "4", "5"}));
    }

    private static string MakeLine(int initVal, int multVal, string sep)
    {
        string[] sArr = new string[10];

        for (int i = initVal; i < initVal + 10; i++)
            sArr[i - initVal] = String.Format("{0,-3}", i * multVal);

        return String.Join(sep, sArr);
    }

    private static string JoinBase(string separator, string[] sArray)
    {
        string concatenatedString = "";

        for (int i = 0; i < sArray.Length; i++)
        {
            if (i < sArray.Length - 1)
            {
                concatenatedString += sArray[i] + separator;
            }
            else
            {
                concatenatedString += sArray[i];
            }
        }
        return concatenatedString;
    }

}

public class Warrior : BaseCharacter
{
    public int warriorStamina;

    public Warrior()
    {
        warriorStamina = base.stamina;
    }
    
    public static void Main()
    {
        System.Console.WriteLine("Hello world");
    }

}

