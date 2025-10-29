namespace Different_Increments
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 4; index++)
            {
                for (int scan = 0; scan <= 24; scan++)
                {
                    if (scan % index == 0)
                    {
                        if (scan == 24)
                        {
                            Console.Write($"{scan} ");
                        }
                        else
                        {
                            Console.Write($"{scan}, ");
                        }
                    }
                    
                }

                Console.Write("\n");
            }
        }
    }
}