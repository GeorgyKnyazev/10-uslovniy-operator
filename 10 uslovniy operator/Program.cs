using System;

namespace _10_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = 9;
            int numberForExponentiation = 2;
            int numberInPower = 1;
            int degreeOfNumber = 1;
 
            while (randomNumber > numberInPower)
            {
                numberInPower *= numberForExponentiation;
               
                if (numberInPower > randomNumber)
                {
                    Console.WriteLine("Исходное число: " + randomNumber);
                    Console.WriteLine("Число больше него: " + numberInPower);
                    Console.WriteLine("Степень исходного числа " + degreeOfNumber);
                }
                degreeOfNumber++;
            }
        }
    }
}
