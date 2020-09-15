using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Int32.Parse(Console.ReadLine());
            if (age <= 20)
            {
                Console.WriteLine("You are too young for this exam");
            } else if (age >= 60)
            {
                Console.WriteLine("You are too old for this exam");
            } else
            {
                Console.WriteLine("Let us begin.");
                Console.WriteLine("Enter your height in meters: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter your weight in kilogramms: ");
                double weight = double.Parse(Console.ReadLine());
                double heightm2 = height * height;
                double BMI = weight / heightm2;
                if(BMI <= 19)
                {
                    Console.WriteLine($"Your BMI is {BMI}, which means you're underweight!");
                } else if (BMI >= 19 && BMI <= 24.9)
                {
                    Console.WriteLine($"Your BMI is {BMI}, which means you're normal!");
                } else if (BMI >= 25 && BMI <= 29)
                {
                    Console.WriteLine($"Your BMI is {BMI}, which means you're overweight!");
                } else
                {
                    Console.WriteLine($"Your BMI is {BMI}, which means you're just really fat actually!");
                }

            }
            

        }
    }
}
