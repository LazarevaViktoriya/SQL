using System;

class Program
{
    static void Main()
    {
        
        double step1 = 85 + 7 / 30.0;
        
        double step2 = 83 + 5 / 18.0;
        
        double step3 = 0.04 != 0 ? (step1 - step2) / 0.04 : 0;
        
        double step4 = 14 + 4 / 30.0;
        
        double step5 = 10 + 5 / 12.0;
        
        double step6 = step4 - step5;
        
        double step7 = step6 >= 0 ? Math.Sqrt(step6) : 0;
        
        double step8 = 18 + 1 / 6.0;
        
        double step9 = 0.02 != 0 ? step8 / 0.02 : 0;
        
        double step10 = step9 != 0 ? step7 / step9 : 0;
        
        double step11 = 1.0 / 5;
        
        double step12 = step3 + step10 + step11;
        
        double result = step12 * (1.0 / 3);
        
        double step14 = Math.Pow(1.0 / 3, 1.0 / 3);
        double finalResult = result - step14;

        // Проверка на NaN
        if (double.IsNaN(finalResult))
        {
            Console.WriteLine("Ошибка: Результат не может быть вычислен.");
        }
        else
        {
            Console.WriteLine("Результат: " + finalResult);
        }
    }
}

