

namespace Calk
{
    internal class MainCommands
    {
        private int first = 0;
        private int second = 0;

        public void Main()
        {
            var enteredVal = "0";

            while (enteredVal != "9")
            {
                MainMenuHeader();
                enteredVal = Console.ReadLine();
                first = 0;
                second = 0;

                if (enteredVal == "1")
                {
                    Summ();
                }
                if (enteredVal == "2")
                {
                    Diff();
                }
                if (enteredVal == "3")
                {
                    Multiplication();
                }
                if (enteredVal == "4")
                {
                    Division();
                }
                if (enteredVal == "5")
                {
                    Degree();
                }
                if (enteredVal == "6")
                {
                    Sqrt();
                }
                if (enteredVal == "7")
                {
                    Percent();
                }
                if (enteredVal == "8")
                {
                    Factorial();
                }
            }
        }

        private bool FillNumbers()
        {
            Console.WriteLine("Введите первое число");
            if (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Вы ввели не число или оно слишком большое");
                return false;
            }

            Console.WriteLine("Введите второе число");
            if (!int.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Вы ввели не число или оно слишком большое");
                return false;
            }


            return true;
        }

        private bool FillNumbers2()
        {
            Console.WriteLine("Введите первое число");
            if (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Вы ввели не число или оно слишком большое");
                return false;
            }

            Console.WriteLine("Введите степень N");
            if (!int.TryParse(Console.ReadLine(), out second))
            {
                Console.WriteLine("Вы ввели не число или оно слишком большое");
                return false;
            }

            return true;
        }

        private bool FillNumbers3()
        {
            Console.WriteLine("Введите число");
            if (!int.TryParse(Console.ReadLine(), out first))
            {
                Console.WriteLine("Вы ввели не число или оно слишком большое");
                return false;
            }

            return true;
        }

        private void Summ()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers();
            }
            
            Console.WriteLine(first + " + " + second + " = " + (first+second));
        }

        private void Diff()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers();
            }
            Console.WriteLine(second + " - " + first + " = " + (second - first));
        }

        private void Multiplication()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers();
            }
            Console.WriteLine(first + " * " + second + " = " + (first*second));
        }

        private void Division()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers();
            }
            Console.WriteLine(first + " / " + second + " = " + (Convert.ToDouble(first) / Convert.ToDouble(second)));
        }

        private void Degree()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers2();
            }
            Console.WriteLine(first + " pow " + second + " = " + Math.Pow(first, second));
        }

        private void Sqrt()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers3();
            }
            Console.WriteLine(first + " sqrt = " + Math.Sqrt(first));
        }


        private void Percent()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers3();
            }
            Console.WriteLine(first + " (1%) = " + Convert.ToDouble(first)/100);
        }

        private void Factorial()
        {
            var isSuccess = false;

            while (!isSuccess)
            {
                isSuccess = FillNumbers3();
            }

            var factr = 1;

            for(var i = 1; i <= first; i++)
            {
                factr *= i;
            }

            Console.WriteLine(first + " (n!) = " + factr);
        }


        protected void MainMenuHeader()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("Выберите цифру для выбора операции из списка");

            Console.WriteLine("1.Сложить 2 числа");
            Console.WriteLine("2.Вычесть первое из второго");
            Console.WriteLine("3.Перемножить два числа");
            Console.WriteLine("4.Разделить первое на второе");
            Console.WriteLine("5.Возвести в степень N первое число");
            Console.WriteLine("6.Найти квадратный корень из числа");
            Console.WriteLine("7.Найти 1 процент от числа");
            Console.WriteLine("8.Найти факториал из числа");
            Console.WriteLine("9.Выйти из программы");
            Console.WriteLine("___________________________________________________");
        }

    }
}
