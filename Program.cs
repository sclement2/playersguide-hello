using System;
using System.Runtime.CompilerServices;

Console.WriteLine("What kind of thing are we talking about?"); 
string thingName = CapitalizeFirstLetter(Console.ReadLine()); /* Name of the "thing" */

Console.WriteLine("How would you describe it? Big? Azure? Tattered?"); 
string thingDescription = CapitalizeFirstLetter(Console.ReadLine()); // Short describer of the "thing"

string thingModifier = "of Doom"; /* Modifier to add to the description */
string thingVersion = "3000"; // Version of the "thing"
Console.WriteLine("The " + thingDescription + thingName + thingModifier + " " + thingVersion + "!");

static string CapitalizeFirstLetter(string source) {
    if (string.IsNullOrEmpty(source))
        return string.Empty;

    char[] letters = source.ToCharArray(); // convert to char array of the string
    letters[0] = char.ToUpper(letters[0]); // capitalize first char
    return new string(letters) + " "; // return the array made of the new char array
}
