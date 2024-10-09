namespace GruppUppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lägg den metod (uppgift) du vill köra här.
        }

        static void Uppgift1()
        {
            Console.Write("Ange tal ett: ");
            string userInput1 = Console.ReadLine();
            int userInt1 = Convert.ToInt32(userInput1);

            Console.Write("Ange tal två: ");
            string userInput2 = Console.ReadLine();
            int userInt2 = Convert.ToInt32(userInput2);

            Console.Write("Ange tal tre: ");
            string userInput3 = Console.ReadLine();
            int userInt3 = Convert.ToInt32(userInput3);

            if (userInt1 + userInt2 == userInt3)
            {
                Console.WriteLine($"Summan av {userInput1} och {userInput2} är lika med {userInput3}");
            }
            else
            {
                Console.WriteLine($"Summan av {userInput1} och {userInput2} är inte lika med {userInput3}");
            }
        }

        static void Uppgift2()
        {
            Console.Write("Ange tal ett: ");
            string userInput1 = Console.ReadLine();
            int userInt1 = Convert.ToInt32(userInput1);

            Console.Write("Ange tal två: ");
            string userInput2 = Console.ReadLine();
            int userInt2 = Convert.ToInt32(userInput2);

            Console.WriteLine($"Talen mellan {userInput1} och {userInput2} som är jämna är: ");
            for (int i = userInt1; i <= userInt2; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
        }

        static void Uppgift3()
        {
            Console.Write("Ange ett tal: ");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);

            Console.WriteLine($"Talen mellan 100 och 1 som är multipel till {userInput} är:");
            for (int i = 100; i >= 1; i--)
            {
                if (i % userInt == 0) Console.WriteLine(i);
            }
        }

        static void ExtraUppgift1()
        {
            Console.Write("Ange ett tal: ");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);

            Console.WriteLine($"Kvadrat med bredden och höjden {userInput}:");
            for (int i = 0; i < userInt; i++)
            {
                for (int j = 0; j < userInt; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void ExtraUppgift2()
        {
            Console.Write("Ange ett tal: ");
            string userInput = Console.ReadLine();
            int userInt = Convert.ToInt32(userInput);
            int rowAmount = 1;

            for (int i = 0; i < userInt; i++)
            {
                for (int j = 0; j < rowAmount; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                rowAmount++;
            }
        }
    }
}
