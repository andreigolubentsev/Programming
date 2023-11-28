using System;

  namespace laborotornaya_rabota_variant2
  {
	    class Program
	    {
        static void Main(string[] args)
        {
            int a1, a2, a3, a4, a5, a6, a7, a8, a10, a11, a12, a13, a14, a16, a17, a18, a19, a20, a21, a23, a24, a25, a26, a27, a28, a30, a31, a32, a33; 
            decimal a9, a15, a22, a29;

            double aAcos, aAsin, aAtan, aAtan2, aBigMul, aCos, aCosh, aAbs, aExp, aLog, aLog10, aMax, aPow, aSign, aSin, aSinh, aSqrt, aTan, aTanh, aMin;
            decimal aCeiling, aFloor, aRound, aTruncate;
            bool aEquals;

            Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");
            Console.ReadKey(true);


            Console.Write("Введите число для определения его абсолютного значения:");
            Int32.TryParse(Console.ReadLine(), out a1);

            Console.Write("Введите число для определения угла, косинус которого равен указанному числу:");
            Int32.TryParse(Console.ReadLine(), out a2);

            Console.Write("Введите число для определения угла, синус которого равен указанному числу:");
            Int32.TryParse(Console.ReadLine(), out a3);

            Console.Write("Введите число для определения угла, тангенс которого равен указанному числу:");
            Int32.TryParse(Console.ReadLine(), out a4);

            Console.Write("Введите первое число для определения угла, тангенс которого равен отношению двух чисел:");
            Int32.TryParse(Console.ReadLine(), out a5);
           
            Console.Write("Введите второе число для определения угла, тангенс которого равен отношению двух чисел:");
            Int32.TryParse(Console.ReadLine(), out a6);

            Console.Write("Введите первое число для умножения двух 32-битовых чисел:");
            Int32.TryParse(Console.ReadLine(), out a7);
            
            Console.Write("Введите второе число для умножения двух 32-битовых чисел:");
            Int32.TryParse(Console.ReadLine(), out a8);

            Console.Write("Введите десятичное число с точкой, чтобы получить наименьшее целое число, которое больше или равно указанному числу:");
            Decimal.TryParse(Console.ReadLine(), out a9);

            Console.Write("Введите число для определения косинуса угла:");
            Int32.TryParse(Console.ReadLine(), out a10);

            Console.Write("Введите число для определения гиперболического косинуса угла:");
            Int32.TryParse(Console.ReadLine(), out a11);

            Console.Write("Введите первое число для сравнения со вторым:");
            Int32.TryParse(Console.ReadLine(), out a12);

            Console.Write("Введите второе число для сравнения с первым:");
            Int32.TryParse(Console.ReadLine(), out a13);

            Console.Write("Введите степень для определения e:");
            Int32.TryParse(Console.ReadLine(), out a14);

            Console.Write("Введите число с плавающей запятой для определения наибольшое целое число, которое меньше или равно указанному:");
            Decimal.TryParse(Console.ReadLine(), out a15);
            
            Console.Write("Введите число для определение его логарифма:");
            Int32.TryParse(Console.ReadLine(), out a16);

            Console.Write("Введите число для определение его логарифма с основанием 10:");
            Int32.TryParse(Console.ReadLine(), out a17);

            Console.Write("Введите первое число для получения большего из двух:");
            Int32.TryParse(Console.ReadLine(), out a18);

            Console.Write("Введите первое число для получения большего из двух:");
            Int32.TryParse(Console.ReadLine(), out a19);

            Console.Write("Введите число для возведения в степень:");
            Int32.TryParse(Console.ReadLine(), out a20);

            Console.Write($"Введите степень для возведения числа {a20}:");
            Int32.TryParse(Console.ReadLine(), out a21);

            Console.Write("Введите число с плавающей запятой для определения ближайшего целого числа:");
            Decimal.TryParse(Console.ReadLine(), out a22);

            Console.Write("Введите число для ввода числа определяющего его знак:");
            Int32.TryParse(Console.ReadLine(), out a23);

            Console.Write("Введите число для определения его синуса:");
            Int32.TryParse(Console.ReadLine(), out a24);

            Console.Write("Введите число для определения его гиперболического синуса:");
            Int32.TryParse(Console.ReadLine(), out a25);

            Console.Write("Введите число для определения его квадратного корня:");
            Int32.TryParse(Console.ReadLine(), out a26);

            Console.Write("Введите число для определения его тангенса:");
            Int32.TryParse(Console.ReadLine(), out a27);

            Console.Write("Введите число для определения его гиперболического тангенса:");
            Int32.TryParse(Console.ReadLine(), out a28);

            Console.Write("Введите число с плавающей запятой для определения целой части числа:");
            Decimal.TryParse(Console.ReadLine(), out a29);

            Console.Write("Введите делимое:");
            Int32.TryParse(Console.ReadLine(), out a30);

            Console.Write("Введите делитель:");
            Int32.TryParse(Console.ReadLine(), out a31);

            Console.Write("Введите первое число для получения меньшего из двух:");
            Int32.TryParse(Console.ReadLine(), out a32);

            Console.Write("Введите второе число для получения меньшего из двух:");
            Int32.TryParse(Console.ReadLine(), out a33);


            Console.WriteLine("Нажмите любую клавишу, для получения математических констант и результатов общей части");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            

            aAbs = Math.Abs(a1);
            aAcos = Math.Acos(a2);
            aAsin = Math.Asin(a3);
            aAtan = Math.Atan(a4);
            aAtan2 = Math.Atan2(a5, a6);
            aBigMul = Math.BigMul(a7, a8);
            aCeiling = Math.Ceiling(a9);
            aCos = Math.Cos(a10);
            aCosh = Math.Cosh(a11);
            aEquals = Math.Equals(a12, a13);
            aExp = Math.Exp(a14);
            aFloor = Math.Floor(a15);
            aLog = Math.Log(a16);
            aLog10 = Math.Log(a17);
            aMax = Math.Max(a18, a19);
            aPow = Math.Pow(a20, a21);
            aRound = Math.Round(a22);
            aSign = Math.Sign(a23);
            aSin = Math.Sin(a24);
            aSinh = Math.Sinh(a25);
            aSqrt = Math.Sqrt(a26);
            aTan = Math.Tan(a27);
            aTanh = Math.Tanh(a28);
            aTruncate = Math.Truncate(a29);
            Math.DivRem(a30, a31, out int aDivRem);
            aMin = Math.Min(a32, a33);





            Console.WriteLine("Экспонента:" + Math.E);
            Console.WriteLine("Число ПИ:" + Math.PI);
            Console.WriteLine($"Абсолютное значение числа {a1}: {aAbs}");
            Console.WriteLine($"Опроеделенный угол, косинус которого равен {a2}: {aAcos}");
            Console.WriteLine($"Опроеделенный угол, синус которого равен {a3}: {aAsin}");
            Console.WriteLine($"Опроеделенный угол, тангенс которого равен {a4}: {aAtan}");
            Console.WriteLine($"Опроеделенный угол, тангенс которого равен отношению чисел {a5} и {a6}: {aAtan2}");
            Console.WriteLine($"Произведение двух 32-битовых числа {a7} и {a8}: {aBigMul}");
            Console.WriteLine($"Опроеделенное наименьшее целое число, которое больше или равно указанному числу {a9}: {aCeiling}");
            Console.WriteLine($"Опроеделенный косинус угла {a10}: {aCos}");
            Console.WriteLine($"Опроеделенный гиперболический косинус угла {a11}: {aCosh}");
            Console.WriteLine($"Результат сравнения {a12} и {a13}: {aEquals}");
            Console.WriteLine($"Опроеделенная e в степени {a14}: {aExp}");
            Console.WriteLine($"Опроеделенное наибольшое целое число, которое меньше или равно {a15}: {aFloor}");
            Console.WriteLine($"Опроеделенный логарифм {a16}: {aLog}");
            Console.WriteLine($"Опроеделенный логарифм с основанием 10 для числа {a17}: {aLog10}");
            Console.WriteLine($"Результат получения большего числа из {a18} и {a19}: {aMax}");
            Console.WriteLine($"Результат возведения {a20} в степень {a21}: {aPow}");
            Console.WriteLine($"Ближайшее целое число для {a22}: {aRound}");
            Console.WriteLine($"Целое число определяющее знак числа {a23}: {aSign}");
            Console.WriteLine($"Определенный синус для {a24}: {aSin}");
            Console.WriteLine($"Определенный гиперболический синус для {a25}: {aSinh}");
            Console.WriteLine($"Определенный квадратный корень для {a26}: {aSqrt}");
            Console.WriteLine($"Определенный тангенс для {a27}: {aTan}");
            Console.WriteLine($"Определенный гиперболический тангенс для {a28}: {aTanh}");
            Console.WriteLine($"Целое число от {a29}: {aTruncate}");
            Console.WriteLine($"Остаток от частного отношения чисел {a30} и {a31} : {aDivRem}");
            Console.WriteLine($"Результат получения меньшего числа из {a32} и {a33}: {aMin}");

            Console.WriteLine("Нажмите любую кнопку, чтобы начать вторую часть работы");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Вариант 2");
            
            double first;
            double second;
            double third;
            
            first = Math.Sqrt(Math.Pow((3 - 2 * Math.Sqrt(5)), 2));
            second = 2 * Math.Abs(3 + 2 * Math.Sqrt(5));
            third = 2 * Math.Pow((5 + Math.Sqrt(2)), 2);
            Console.WriteLine(first - second - third);
            
            Console.WriteLine("Для завершения программы нажмите любую клавишу...");
            Console.ReadKey();

        }
        }
  }
