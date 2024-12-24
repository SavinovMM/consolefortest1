using System;
using mylibrary1;

class Program
{
    static void Main(string[] args)
    {
        Class1 evaluator = new Class1();

        while (true)
        {
            Console.WriteLine("Введите математическое выражение (или 'exit' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            try
            {
                double result = evaluator.Evaluate(input);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
