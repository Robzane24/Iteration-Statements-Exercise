namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void NumThousand()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void NumThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }    

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void NumEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The two numbers are equal");
            }
            else
            {
                Console.WriteLine("The two numbers are not equal");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num1)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("This number is Even");
            }
            else
            {
                Console.WriteLine("This number is Odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int num1)
        {
            if (num1 < 0)
            {
                Console.WriteLine("This number is negative");
            }
            else
            {
                Console.WriteLine("This number is positive");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VoteAge()
        {
            Console.WriteLine("What is your age?");
            var answer = Console.ReadLine();

            if(int.Parse(answer) > 18)
            {
                Console.WriteLine("You are old enough to vote");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void NumRange()
        {
            Console.WriteLine("Pick a number");
            var answer = Console.ReadLine();

            if(int.Parse(answer) <= 10 && int.Parse(answer) >= -10)
            {
                Console.WriteLine("The number is in the range");
            }
            else
            {
                Console.WriteLine("The number is not the range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {
            for(int i = 0; i <= 12; i++)
            {

            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            NumThousand();

            NumThrees();

            NumEqual(2, 4);

            EvenOrOdd(5);

            PosOrNeg(12);

            VoteAge();

            NumRange();

            MultTable();
        }
    }
}
