using System;

namespace csharpbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbatimSample = @"\\\n~`.'";
            string normalString = "Greetings";
            double piApproximation = 3.14;
            int bigNum = 70_000_000;
            long longerInt = 10000000;
            decimal price = 9.99M;
            char letter = 's';
            string deseret = "𐐯"; //deseret sample
            bool greenLight = false;
            //string password = string.Empty;

            string[]names = new string[4];

            names[0] = "Ert";
            names[1] = "Jill";
            names[2] = "Jack";
            names[3] = "Three";

            for(int i = 0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Hello Again");
            Console.WriteLine(verbatimSample);
            Console.WriteLine(sizeof(int));
            Console.WriteLine(int.MinValue);
            Console.WriteLine(normalString);
            Console.WriteLine(piApproximation);
            Console.WriteLine(letter);
            Console.WriteLine(bigNum);
            Console.WriteLine(greenLight);
            Console.WriteLine(deseret);
            Console.WriteLine(price);
            Console.WriteLine(longerInt);
            TimesTable(7);
            Console.WriteLine(Factorial(4));
            Console.WriteLine();

        }

        public void talk(){
            /*
            string password = "";
            do{
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            } while (password != "Pa$$w0rd");
            Console.WriteLine(password);
            */
        }

        static void TimesTable(int num){
            Console.WriteLine($"This is the {num} times table:");
            for( int row = 1; row<= 12; row++){
                Console.WriteLine($"{row} x {num} = { row * num}");
            }
            Console.WriteLine();
        }

        static int Factorial(int num){
            if (num < 1){
                return 0;
            }
            else if(num == 1){
                return 1;
            }
            else{
                return num * Factorial(num -1);
            }
        }

        

        public enum WondersOfTheAncientWorld
        {
            GreatPyramidOfGiza,
            HangingGardensOfBabylon,
            StatueOfZeusAtOlympia,
            TempleOfArtemisAtEphesus,
            ColossusOfRhodes,
            LighthouseOfAlexandria
        }
    }
}
