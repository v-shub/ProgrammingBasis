using System.Runtime.CompilerServices;

namespace ProgrammingBasis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string task1 = "1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними";
            string task2 = "2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:\n\ta. сложение\n\tb. вычитание\n\tc. умножение\n\td. деление\n\te. нахождение остатка (оператор %)";
            string task3 = "3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта";
            string task4 = "4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути";
            string task5 = "5. Разработайте программу для нахождения самого длинного слова в предложении";
            string task6 = "6. Разработайте программу, которая может перемножить два массива значений";
            string task7 = "7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных";
            string task8 = "8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем";
            string task9 = "9. Часть 2. Напечатать полную таблицу умножения в виде:\n\t1 х 1 = 1   1 х 2 = 2  ...  1 х 9 = 9\n\t2 х 1 = 2   2 х 2 = 4  ...  2 х 9 = 18\n\t...         ...        ...  ...\n\t9 х 1 = 9   9 х 2 = 18 ...  9 х 9 = 81";
            string task10 = "10. Часть 3. Разработайте программу, которая на основе введенного двузначного числа выводит следующие результаты:\n\t1. Является ли сумма его цифр двузначным числом\n\t2. Определить больше ли первая цифра в степени второй цифры чем указанное двухзначное число.";
            while (true)
            {
                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine(task1);
                Console.WriteLine(task2);
                Console.WriteLine(task3);
                Console.WriteLine(task4);
                Console.WriteLine(task5);
                Console.WriteLine(task6);
                Console.WriteLine(task7);
                Console.WriteLine(task8);
                Console.WriteLine(task9);
                Console.WriteLine(task10);
                string choiceNum = Console.ReadLine();
                Console.Clear();
                switch (choiceNum)
                {
                    case "1":
                        Console.WriteLine(task1);
                        Console.WriteLine("Enter the first number:");
                        int a = ParseIntTilWin();
                        Console.WriteLine("Enter the second number:");
                        int b = ParseIntTilWin();
                        Console.WriteLine("Enter the third number:");
                        int c = ParseIntTilWin();
                        Console.WriteLine("Enter the fourth number:");
                        int d = ParseIntTilWin();
                        Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {AverageOfFour(a, b, c, d)}");
                        break;
                    case "2":
                        Console.WriteLine(task2);
                        Calculator();
                        break;
                    case "3":
                        Console.WriteLine(task3);
                        ConvertTemperature();
                        break;
                    case "4":
                        Console.WriteLine(task4);
                        break;
                    case "5":
                        Console.WriteLine(task5);
                        break;
                    case "6":
                        Console.WriteLine(task6);
                        break;
                    case "7":
                        Console.WriteLine(task7);
                        break;
                    case "8":
                        Console.WriteLine(task8);
                        break;
                    case "9":
                        Console.WriteLine(task9);
                        break;
                    case "10":
                        Console.WriteLine(task10);
                        break;
                    default:
                        Console.WriteLine("It is not a task number. Try again.");
                        break;
                }
                Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
                Console.ReadLine();
                Console.Clear();
            }
            int ParseIntTilWin()
            {
                int x;
                while (true)
                {
                    bool aInt = Int32.TryParse(Console.ReadLine(), out x);
                    if (aInt)
                        break;
                    else
                        Console.WriteLine("It is not an integer number. Try again.");
                }
                return x;
            }
            double AverageOfFour(int a, int b, int c, int d)
            {
                return (a + b + c + d)/4.00;
            }
            void Calculator()
            {
                double result = 0;
                string action = "";
                Console.WriteLine("Введите два числа:");
                int x = ParseIntTilWin();
                int y = ParseIntTilWin();
                Console.WriteLine($"Вы ввели числа: {x} и {y}\nКакое действие выполнить?\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Нахождение остатка");
                int actionNum;
                while (true)
                {
                    bool aInt = Int32.TryParse(Console.ReadLine(), out actionNum);
                    if (aInt & actionNum > 0 & actionNum < 6)
                        break;
                    else
                        Console.WriteLine("It is not an action number. Try again.");
                }
                switch (actionNum)
                {
                    case 1:
                        result = x + y;
                        action = "+";
                        break;
                    case 2:
                        result = x - y;
                        action = "-";
                        break;
                    case 3:
                        result = x * y;
                        action = "*";
                        break;
                    case 4:
                        result = x / Convert.ToDouble(y);
                        action = "/";
                        break;
                    case 5:
                        result = x % y;
                        action = "%";
                        break;
                }
                Console.WriteLine($"Результат: {x} {action} {y} = {result}");
            }
            void ConvertTemperature()
            {
                string tempVars = "1. Цельсий\n2. Кельвин\n3. Фаренгейт";
                Console.WriteLine("Выберите шкалу вводимой температуры:\n" + tempVars);
                int scaleNum1 = ParseTemperatureScaleNum();
                Console.WriteLine("Введите показатель температура (градусы):");
                double temperature = ParseIntTilWin();
                Console.WriteLine("Выберите тип шкалы для конвертации:\n" + tempVars);
                int scaleNum2 = ParseTemperatureScaleNum();
                switch(scaleNum1)
                {
                    case 2:
                        temperature -= 273.15;
                        break;
                    case 3:
                        temperature = (temperature - 32) * 5 / 9;
                        break;
                }
                switch(scaleNum2)
                {
                    case 2:
                        temperature += 273.15;
                        break;
                    case 3:
                        temperature = temperature * 9 / 5 + 32;
                        break;
                }
                Console.WriteLine($"Результат конвертации: {temperature}");
            }
            int ParseTemperatureScaleNum()
            {
                int scaleNum = 0;
                while (true)
                {
                    bool aInt = Int32.TryParse(Console.ReadLine(), out scaleNum);
                    if (aInt & scaleNum > 0 & scaleNum < 4)
                        break;
                    else
                        Console.WriteLine("It is not the scale number. Try again.");
                }
                return scaleNum;
            }
        }
    }
}