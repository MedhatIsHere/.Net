//using System;

//class Program
{
    // static void Main(string[] args)
    //{

    // Age calculator
    #region
    int currentDay = 22;
        int currentMonth = 10;
        int currentYear = 2024;

        int birthYear = GetValidYear();
        int birthMonth = GetValidMonth();
        int birthDay = GetValidDay(birthMonth, birthYear);

        CalculateAge(birthDay, birthMonth, birthYear, currentDay, currentMonth, currentYear);
    }

    static int GetValidYear()
    {
        int year;
        do
        {
            Console.WriteLine("Please enter your year from 1980->2023:");
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }
        } while (year < 1980 || year > 2023);
        return year;
    }

    static int GetValidMonth()
    {
        int month;
        do
        {
            Console.WriteLine("Please enter your month (1-12):");
            while (!int.TryParse(Console.ReadLine(), out month))
            {
                Console.WriteLine("Invalid input. Please enter a valid month.");
            }
        } while (month < 1 || month > 12);
        return month;
    }

    static int GetValidDay(int month, int year)
    {
        int maxDays = GetDaysInMonth(month, year);
        int day;
        do
        {
            Console.WriteLine($"Please enter your day (1-{maxDays}):");
            while (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("Invalid input. Please enter a valid day.");
            }
        } while (day < 1 || day > maxDays);
        return day;
    }

    static int GetDaysInMonth(int month, int year)
    {
        if (month == 2)
        {
            return IsLeapYear(year) ? 29 : 28;
        }
        else if (new[] { 4, 6, 9, 11 }.Contains(month))
        {
            return 30;
        }
        return 31;
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static void CalculateAge(int birthDay, int birthMonth, int birthYear,
                           int currentDay, int currentMonth, int currentYear)
    {
        int years = currentYear - birthYear;
        int months = currentMonth - birthMonth;
        int days = currentDay - birthDay;

        if (days < 0)
        {
            months--;
            days += GetDaysInMonth(birthMonth, birthYear);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        Console.WriteLine($"You're {years} years, {months} months, and {days} days old");
        #endregion



        //calculator
        #region
        char continueCalculation;

        do
        {

            Console.WriteLine("Please enter #1:");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }


            Console.WriteLine("Please enter #2:");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }


            Console.WriteLine("Please enter operator (+, -, *, /):");
            char op;
            bool validOperator = false;
            do
            {
                op = Console.ReadLine()?.FirstOrDefault() ?? ' ';
                validOperator = op is '+' or '-' or '*' or '/';
                if (!validOperator)
                {
                    Console.WriteLine("Invalid operator. Please enter +, -, *, or /:");
                }
            } while (!validOperator);


            double result = Calculate(num1, num2, op);


            Console.WriteLine($"{num1}{op}{num2}={result}");


            do
            {
                Console.WriteLine("Continue? y or n");
                continueCalculation = char.ToLower(Console.ReadLine()?.FirstOrDefault() ?? 'n');
            } while (continueCalculation != 'y' && continueCalculation != 'n');

        } while (continueCalculation == 'y');

        Console.WriteLine("Program end");
    }

    static double Calculate(double num1, double num2, char op)
    {
        return op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 :
                throw new DivideByZeroException("Cannot divide by zero")

        };
        #endregion


        // min & max array
        #region
        int[] arr = new int[10];


        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }


        int min = arr[0], max = arr[0];
        for (int i = 1; i < 10; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }

        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");

        #endregion


        // sorting array
        #region
        int[] arr = new int[10];


        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("\nOriginal array:");
        for (int i = 0; i < 10; i++)
            Console.Write($"{arr[i]} ");


        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }


        Console.WriteLine("\nSorted array:");
        for (int i = 0; i < 10; i++)
            Console.Write($"{arr[i]} ");

        #endregion



        //  array search
        #region
        int[] arr = new int[10];


        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("\nWhich number you want to search?");
        int searchNumber = int.Parse(Console.ReadLine());


        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == searchNumber)
            {
                Console.WriteLine($"Found at index {i}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Number not found in array");
        }

        #endregion




        //  2Darray sum of rows
        #region
        int[,] arr = new int[3, 4];


        Console.WriteLine("Enter values for 3x4 array:");
        for (int row = 0; row < 3; row++)
        {
            Console.WriteLine($"\nEnter 4 numbers for row {row + 1}:");
            for (int col = 0; col < 4; col++)
            {
                Console.Write($"Enter number {col + 1}: ");
                arr[row, col] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("\nArray and Row Sums:");
        for (int row = 0; row < 3; row++)
        {
            int rowSum = 0;

            for (int col = 0; col < 4; col++)
            {
                Console.Write($"{arr[row, col]}\t");
                rowSum += arr[row, col];
            }

            Console.WriteLine($"| Sum = {rowSum}");
        }
        #endregion



        //Bonus multiply 2 matrix
        //3*2    *  2*1  =  3*1

        #region

        int[,] matrix1 = new int[3, 2];

        int[,] matrix2 = new int[2, 1];

        int[,] result = new int[3, 1];


        Console.WriteLine("Enter values for first matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter 2 numbers for row {i + 1}:");
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Enter number {j + 1}: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("\nEnter values for second matrix (2x1):");
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            matrix2[i, 0] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < 3; i++)
        {
            result[i, 0] = 0;
            for (int j = 0; j < 2; j++)
            {
                result[i, 0] += matrix1[i, j] * matrix2[j, 0];
            }
        }


        Console.WriteLine("\nFirst Matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{matrix1[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSecond Matrix (2x1):");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(matrix2[i, 0]);
        }

        Console.WriteLine("\nResult Matrix (3x1):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(result[i, 0]);
        }
        #endregion



        //Bonus multiply 2 matrix
        //3*3     *    3*2   =  3*2

        #region


        int[,] matrix1 = new int[3, 3];

        int[,] matrix2 = new int[3, 2];

        int[,] result = new int[3, 2];


        Console.WriteLine("Enter values for first matrix (3x3):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter 3 numbers for row {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter number {j + 1}: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("\nEnter values for second matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nEnter 2 numbers for row {i + 1}:");
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Enter number {j + 1}: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }


        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }


        Console.WriteLine("\nFirst Matrix (3x3):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix1[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSecond Matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{matrix2[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nResult Matrix (3x2):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"{result[i, j]}\t");
            }
            Console.WriteLine();
        }
    #endregion




//  }
//}