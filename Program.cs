namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int Number = Convert.ToInt32(Console.ReadLine());

            /*Task 1*/

            bool isPrime = true;
            for (int i = 2; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Number is a prime");
            }
            else
            {
                Console.WriteLine("Number is not a prime");
            }


            /*Task 2*/

            for (; Number % 2 == 0 && Number > 0;)
            {
                Number /= 2;
            }
            if (Number == 1)
            {
                Console.WriteLine(Number + " is a power of 2");
            }
            else
            {
                Console.WriteLine(Number + " is not a power of 2");
            }


            /*Task 3*/

            int FloorOfNumber = 0;

            for (; Number > 0; Number /= 10)
            {
                FloorOfNumber++;
            }
            Console.WriteLine("Number of floors " + FloorOfNumber);

        }
    }
}
