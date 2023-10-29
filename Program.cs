namespace CS_DZ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();

            calc.MyEvent += Calc_MyEvent;
            
            string action = "";
            Console.WriteLine("Введите число: ");
            calc.Result = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Выберете действие: +, -, *, /, q - для выхода");
                action = Console.ReadLine();
                if (action == "+" || action == "-" || action == "*" || action == "/")
                {
                    Console.WriteLine("Введите число: ");
                    var num = Console.ReadLine();
                    if (double.TryParse(num, out double n))
                    {
                        switch (action)
                        {
                            case "+": calc.Sum(n); continue;
                            case "-": calc.Sub(n); continue;
                            case "*": calc.Mul(n); continue;
                            case "/": calc.Div(n); continue;                              
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка: Введено не число ({num})");
                    }
                }
                else if(!(action == "q" || action == ""))
                {
                    Console.WriteLine("Некорректный оператор");
                }

            }
            while (action != "q" && action != "");
            Console.WriteLine("Работа завершена");

        }


        private static void Calc_MyEvent(object? sender, EventArgs e)
        {
            if (sender is Calc)
                Console.WriteLine(((Calc)sender).Result);
        }
    }
}