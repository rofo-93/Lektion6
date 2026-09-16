namespace Lektion6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tryparse

            //Console.WriteLine("Skriv ett heltal som du vill addera med 5.");
            //string userInput = Console.ReadLine();
            //int userNumber;

            //while (!int.TryParse(userInput, out userNumber))
            //{
            //    Console.WriteLine("Du måste ange ett heltal, försök igen");
            //    userInput = Console.ReadLine();
            //}

            //int totaloftwonumbers = 5 + userNumber;
            //Console.WriteLine(totaloftwonumbers);



            //Var och Dynamic


            //var age = 23 + " Robin " + 22.3;
            //var name = "Robin";
            //var isSuccess = true;
            //var decimalNumber = 22.3;

            //Console.WriteLine(age);


            //dynamic streetNumber = 3;
            //streetNumber = "Hej";
            //streetNumber = true;

            //Console.WriteLine(streetNumber);









            var numbers = new int[3] { 7, 4, 2 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }













            
        }


        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hej {name}");
        }



    }
}
