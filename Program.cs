using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

internal class Program
{
    static float floatVariable = 14.556f;
    static double doubleVariable = 14.556;
    static decimal decimalVariable = 14.555556m;

    static int intVariable = -20;
    static uint uintVariable = 22;
    static short shortVariable = 11;
    static ushort ushortVariable = 2;
    static long longVariable = 21_456;
    static ulong ulongVariable = 3245;
    static byte byteVariable = 22;
    static sbyte sbyteVariable = -22;

    static string stringVariable = "I am a string";
    static char charVariable = 'I';

    static bool boolVariable = false;

    private static void Main(string[] args)
    {

        //Console.WriteLine("What kind of thing are we talking about?");
        //string thingName = CapitalizeFirstLetter(Console.ReadLine()); /* Name of the "thing" */

        //Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        //string thingDescription = CapitalizeFirstLetter(Console.ReadLine()); // Short describer of the "thing"

        //string thingModifier = "of Doom"; /* Modifier to add to the description */
        //string thingVersion = "3000"; // Version of the "thing"
        //Console.WriteLine("The " + thingDescription + thingName + thingModifier + " " + thingVersion + "!");

        VariableTypes();

        intVariable = 0b00001101; // change to a binary number for 13
        Console.WriteLine("");
        IntVariableTypes();

        intVariable = 0XFF00FF; // change to a binary number for 13
        Console.WriteLine("");
        IntVariableTypes();

        charVariable = '\u0061'; // hexadecimal unicode
        Console.WriteLine("");
        CharacterVariableTypes();

        doubleVariable = 6.022e23; // scientific format
        Console.WriteLine("");
        FloatingPointVariableTypes();

        UpdateValues();


        static string CapitalizeFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;

            char[] letters = source.ToCharArray(); // convert to char array of the string
            letters[0] = char.ToUpper(letters[0]); // capitalize first char
            return new string(letters) + " "; // return the array made of the new char array
        }

        static void VariableTypes()
        {
            // write out the values for all the variables
            FloatingPointVariableTypes();
            Console.WriteLine("");
            IntVariableTypes();
            Console.WriteLine("");

            Console.WriteLine($"boolVariable: {boolVariable}  type: {boolVariable.GetType()}");

        }

        static void IntVariableTypes()
        {
            Console.WriteLine($"intVariable: {intVariable}  type: {intVariable.GetType()}");
            Console.WriteLine($"uintVariable: {uintVariable}  type: {uintVariable.GetType()}");
            Console.WriteLine($"shortVariable: {shortVariable}  type: {shortVariable.GetType()}");
            Console.WriteLine($"ushortVariable: {ushortVariable}  type: {ushortVariable.GetType()}");
            Console.WriteLine($"longVariable: {longVariable}  type: {longVariable.GetType()}");
            Console.WriteLine($"ulongVariable: {ulongVariable}  type: {ulongVariable.GetType()}");
            Console.WriteLine($"byteVariable: {byteVariable}  type: {byteVariable.GetType()}");
            Console.WriteLine($"sbyteVariable: {sbyteVariable}  type: {sbyteVariable.GetType()}");

        }

        static void FloatingPointVariableTypes()
        {
            Console.WriteLine($"floatVariable: {floatVariable}  type: {floatVariable.GetType()}");
            Console.WriteLine($"doubleVariable: {doubleVariable}  type: {doubleVariable.GetType()}");
            Console.WriteLine($"decimalVariable: {decimalVariable}  type: {decimalVariable.GetType()}");

        }

        static void CharacterVariableTypes()
        {
            Console.WriteLine($"stringVariable: {stringVariable}  type: {stringVariable.GetType()}");
            Console.WriteLine($"charVariable: {charVariable}  type: {charVariable.GetType()}");

        }

        static void UpdateValues()
        {
            bool validChoice = true;

            while (validChoice)
            {
                Console.WriteLine("");
                Console.WriteLine("Select which variable you would like to update");
                Console.WriteLine("1 - float");
                Console.WriteLine("2 - double");
                Console.WriteLine("3 - decimal");

                Console.WriteLine("4 - int");
                Console.WriteLine("5 - uint");
                Console.WriteLine("6 - short");
                Console.WriteLine("7 - ushort");
                Console.WriteLine("8 - long");
                Console.WriteLine("9 - ulong");
                Console.WriteLine("10 - byte");
                Console.WriteLine("11 - sbyte");

                Console.WriteLine("12 - string");
                Console.WriteLine("13 - char");

                Console.WriteLine("14 - bool");

                // use a switch statement to update the values for the various variable types
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("You selected float. Enter float value:");
                            if (float.TryParse(Console.ReadLine(), out floatVariable))
                            {
                                Console.WriteLine($"You entered: {floatVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid float value.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("You selected double. Enter a double value:");
                            if (double.TryParse(Console.ReadLine(), out doubleVariable))
                            {
                                Console.WriteLine($"You entered: {doubleVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid double value.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("You selected decimal. Enter decimal value:");
                            if (decimal.TryParse(Console.ReadLine(), out decimalVariable))
                            {
                                Console.WriteLine($"You entered: {decimalVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid decimal value.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("You selected int. Enter an integer value:");
                            if (int.TryParse(Console.ReadLine(), out intVariable))
                            {
                                Console.WriteLine($"You entered: {intVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer value.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("You selected uint. Enter an unsigned integer value:");
                            if (uint.TryParse(Console.ReadLine(), out uintVariable))
                            {
                                Console.WriteLine($"You entered: {uintVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid unsigned integer value.");
                            }
                            break;
                        case 6:
                            Console.WriteLine("You selected short. Enter an short integer value:");
                            if (short.TryParse(Console.ReadLine(), out shortVariable))
                            {
                                Console.WriteLine($"You entered: {shortVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid short integer value.");
                            }
                            break;
                        case 7:
                            Console.WriteLine("You selected ushort. Enter an unsigned short integer value:");
                            if (ushort.TryParse(Console.ReadLine(), out ushortVariable))
                            {
                                Console.WriteLine($"You entered: {ushortVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid unsigned short integer value.");
                            }
                            break;
                        case 8:
                            Console.WriteLine("You selected long. Enter a long integer value:");
                            if (long.TryParse(Console.ReadLine(), out longVariable))
                            {
                                Console.WriteLine($"You entered: {longVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid long integer value.");
                            }
                            break;
                        case 9:
                            Console.WriteLine("You selected ulong. Enter an unsigned long integer value:");
                            if (ulong.TryParse(Console.ReadLine(), out ulongVariable))
                            {
                                Console.WriteLine($"You entered: {ulongVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid unsigned long integer value.");
                            }
                            break;
                        case 10:
                            Console.WriteLine("You selected byte. Enter a byte value:");
                            if (byte.TryParse(Console.ReadLine(), out byteVariable))
                            {
                                Console.WriteLine($"You entered: {byteVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid byte value.");
                            }
                            break;
                        case 11:
                            Console.WriteLine("You selected sbyte. Enter a signed byte value:");
                            if (sbyte.TryParse(Console.ReadLine(), out sbyteVariable))
                            {
                                Console.WriteLine($"You entered: {sbyteVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid signed byte value.");
                            }
                            break;
                        case 12:
                            Console.WriteLine("You selected string. Enter a string:");
                            stringVariable = Console.ReadLine();
                            Console.WriteLine($"You entered: {stringVariable}");
                            break;
                        case 13:
                            Console.WriteLine("You selected char. Enter a single character:");
                            if (char.TryParse(Console.ReadLine(), out charVariable))
                            {
                                Console.WriteLine($"You entered: {charVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a single character.");
                            }
                            break;
                        case 14:
                            Console.WriteLine("You selected bool. Enter true or false");
                            if (bool.TryParse(Console.ReadLine(), out boolVariable))
                            {
                                Console.WriteLine($"You entered: {boolVariable}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter true or false.");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Program is exiting");
                            validChoice = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.WriteLine("Try again? Y or N");
                    string response = Console.ReadLine();
                    if (!string.Equals(response, "y", StringComparison.OrdinalIgnoreCase))
                    {
                        validChoice = false;
                        Console.WriteLine("Program is exiting");
                    }
                }
            }
        }
    }
}