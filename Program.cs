using RomanNumeralKata;

RomanNumeral romanNumeral= new RomanNumeral();

Console.WriteLine(" Int to Roman converter");
Console.WriteLine("pls enter your choice\n");
Console.WriteLine("1. Roman to Int converter \n");
Console.WriteLine("2. Int to Roman converter \n");
int choice = Convert.ToInt32(Console.ReadLine());
bool endApp = false;
// Display title as the C# Roman Numeral Converter app.
Console.WriteLine("Console Roman Numeral Converter app C#\r");
Console.WriteLine("------------------------\n");

while (!endApp)
{
    if (choice == 1)
    {
        // Declare variables and set to empty.
        string user_input = "";
        int result = 0;

        // Ask the user to enter roman numerals.
        Console.Write("Type a Roman Numeral, and then press Enter: ");
        user_input = Console.ReadLine();

        //  check for empty input 
        while (user_input.Length == 0)
        {
            Console.Write("This is not valid input. Please enter a valid roman numeral ");
            user_input = Console.ReadLine();
        }

        try
        {
            result = romanNumeral.RomanToInt(user_input.ToUpper());
            if (result == 0)
            {
                Console.WriteLine("This Roman Numeral not present in my Roman dictionary");
            }
            else Console.WriteLine("Your Number: {0:0.##}\n", result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Oh no! An exception occurred " + e.Message);
        }

        Console.WriteLine("------------------------\n");

        // Wait for the user to respond before closing.
        Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
        if (Console.ReadLine() == "n") endApp = true;

        Console.WriteLine("\n"); // Friendly linespacing.
    }  


     if (choice == 2)
    {   

        // Declare variables and set to empty.
        int input = 0;
        string result = "";

        // Ask the user to enter roman numerals.
        Console.Write("Type a Integer number, and then press Enter: ");
        input = Convert.ToInt32(Console.ReadLine());

        try
        {
            result = romanNumeral.IntToRoman(input);

            Console.WriteLine("Your Roman Number: {0:0.##}\n", result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Oh no! An exception occurred " + e.Message);
        }

        Console.WriteLine("------------------------\n");

        // Wait for the user to respond before closing.
        Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
        if (Console.ReadLine() == "n") endApp = true;

        Console.WriteLine("\n"); // Friendly linespacing.
    }
    return;

}
