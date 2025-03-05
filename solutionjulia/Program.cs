namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***********************************************
             *  Character type
             **********************************************/
            char middleInitial = 'J';
            Console.WriteLine("My middle initial is " + middleInitial);

            /***********************************************
             *  Integer types
             **********************************************/
            Console.Write("Enter a num: ");
            short examScore = 30;
            Console.WriteLine("My exam score was " + examScore);

            int countriesRepresented = 65;
            Console.WriteLine("There were " + countriesRepresented + " countries represented in my meeting");

            long peopleInFlorida = 20610000;
            Console.WriteLine("There are about " + peopleInFlorida + " people in Florida");

            /***********************************************
             *  Floating point types
             **********************************************/
            float carPayment = 401.23f;
            Console.WriteLine("My car payment is " + carPayment);

            double pi = 3.14159;
            Console.WriteLine("PI is " + pi);

            /***********************************************
             *  Boolean type
             **********************************************/
            bool gameOver = false;
            Console.WriteLine("The value of gameOver is " + gameOver);

            /***********************************************
             *  Overflow example
             **********************************************/
            short value1 = 32000;
            short value2 = 1000;
            int product = value1 * value2; // Int32 used instead of short to handle the larger product
            Console.WriteLine("The product of" + value1 + " and " + value2 + " is " + product);

            /***********************************************
             *  String
             **********************************************/
            string value3 = "test";
            Console.WriteLine(value3);


            /***********************************************
             *  Challenge
             **********************************************/
            Console.Write("Enter your favorite number between 1 and 100: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Amazing!! That's my favorite number too!");
            Console.WriteLine($"No really!!, {value} is my favorite number!");



            //Console.ReadLine();
        }
    }
}





