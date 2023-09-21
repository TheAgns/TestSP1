using System.Text;

namespace App;

public class RomanNumeralConverter {
    private static readonly int[] Values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    private static readonly string[] Symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
    
    public string ToRomanNumbers(int number)
    {
        if (number < 1 || number > 3999)
            throw new ArgumentOutOfRangeException("Value must be in the range 1-3999.");
        var result = new StringBuilder();

        for (var i = 0; i < Values.Length && number > 0; i++)
        {
            while (number >= Values[i])
            {
                number -= Values[i];
                result.Append(Symbols[i]);
            }
        }
        return result.ToString();
    }
}