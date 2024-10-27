using System.Xml.XPath;

class Conversion
{

    private static void verify(string binary)
    {
        if (string.IsNullOrEmpty(binary))
        {
            throw new Exception("Binary number cannot be null!");
            
        }
        if (binary.Length > 8)
        {
            throw new Exception("Binary number cannot exceed 8 digits!");
        }

        foreach (char c in binary)
        {
            if (c != '0' && c != '1')
            {
                throw new Exception("Invalid Binary!");
            }
        }
        
    }
    public static int bin2dec(string binary)
    {
        int decimalValue = 0;

        verify(binary);

        for (int i = binary.Length-1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                decimalValue += (int)Math.Pow(2, binary.Length - 1 - i);
            }
        }
        return decimalValue;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bin2Dec program!");
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine() ?? "Binary number cannot be null";

        int result = Conversion.bin2dec(binary);

        Console.WriteLine($"The decimal number is: {result}");
    }
}