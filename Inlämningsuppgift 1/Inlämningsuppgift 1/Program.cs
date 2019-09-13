using System;

namespace Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Number = new Random();

            int RandomNumber = Number.Next(1, 101); //Här bestämmer jag vilka tal du kan skriva in och ett nummer mellan 1-101 kommer att skrivas ut som du ska gissa
            int tal = 0;
            int kys = 0;
            Console.WriteLine("Guess a number between 1-101");  //Här kommer det som bestämmer vilka tal du får skriva in nedan


            do
            {
                kys++;

                tal = Convert.ToInt32(Console.ReadLine());    //Här har vi ett tal som du skriver in
                
                if (RandomNumber > tal)  //Här kommer det tal du valt att skriva jämföras och om det är mindre kommer det som står nedan skrivas ut
                    Console.WriteLine("Your guess was too low, guess a higher number"); 
                else if (RandomNumber < tal)  //Här kommer det tal du valt att skriva jämföras och om det är större kommer det som står nedan att skrivas ut
                    Console.WriteLine("Your guess was too high, guess a lower number");
                else if (RandomNumber == tal)  //Om ditt tal skulle vara rätt så kommer det som står nedan skrivas ut
                    Console.WriteLine("You guessed correct, it took you "+kys+" tries");
                    
            } while (RandomNumber != tal); //Här tar loopen slut och programmet termineras efter att du gissat rätt och tryckt på enter

        }


    }
}
