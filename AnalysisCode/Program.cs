class Program
{
    static void Main()
    {
        int max = 500;

        if (max > byte.MaxValue)
        {
            Console.WriteLine("Warning: max is greater than byte.MaxValue, loop may overflow!");
        }

        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);

            if (i == byte.MaxValue)
            {
                Console.WriteLine("Byte overflow would occur. Stopping loop to prevent infinite loop.");
                break;
            }
        }
    }
}