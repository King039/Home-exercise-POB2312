//дз 5.1
//const double MM_TO_CM = 0.1;
//const double MM_TO_M = 0.0001;
//const double MM_TO_KM = 0.000001;
//const double MM_TO_MILI = 6.213711922373341e-7;
//const double MM_TO_YD = 0.0010936132983;


//Console.WriteLine("Введите колличество мм: ");
//double mm = double.Parse(Console.ReadLine());
//double cm = mm * MM_TO_CM;
//Console.WriteLine($"{cm}см");


//double m = mm * MM_TO_M;
//Console.WriteLine($"{m}м");


//double km = mm * MM_TO_KM;
//Console.WriteLine($"{km}км");


//double mili = mm * MM_TO_MILI;
//Console.WriteLine($"{mili}мили");


//double yd = mm * MM_TO_YD;
//Console.WriteLine($"{yd}ярд");


// дз 5.2
// Первый продукт "кофе стандарт" цена 69,0 ; колличество 1

//Console.WriteLine("Укажите продукт: ");
//string firstProductName = Console.ReadLine();
//Console.WriteLine($"Укажите цену {firstProductName}: ");
//decimal firstProductPrice = decimal.Parse(Console.ReadLine());
//Console.WriteLine($"Укажите колличество продукта {firstProductName} , по цене {firstProductPrice}: ");
//int firstProductQuantity = int.Parse(Console.ReadLine());
//decimal sum = firstProductPrice * firstProductQuantity;

////// Второй продукт "рулет-спринг тв из ку" цена 70,0 ; колличество 1

//Console.WriteLine("Укажите продукт: ");
//string secondProductName = Console.ReadLine();
//Console.WriteLine($"Укажите цену {secondProductName}: ");
//decimal secondProductPrice = decimal.Parse(Console.ReadLine());
//Console.WriteLine($"Укажите колличество продукта {secondProductName} , по цене {secondProductPrice}: ");
//int secondProductQuantity = int.Parse(Console.ReadLine());
//decimal sum2 = secondProductPrice * secondProductQuantity;

//Console.WriteLine("*********************************************************");
//Console.WriteLine("№ Название\t\t\tЦена\tКолличество\tСумма");
//Console.WriteLine($"№1 {firstProductName}\t\t{firstProductPrice}\t{firstProductQuantity}\t\t{sum}");
//Console.WriteLine("НДС с расчитаной ставкой 18%\t\t\t\t10.53");
//Console.WriteLine($"№2 {secondProductName}\t{secondProductPrice}\t{secondProductQuantity}\t\t{sum2}");
//Console.WriteLine("НДС с расчитаной ставкой 10%\t\t\t\t6.36");
//Console.WriteLine("*********************************************************");
//Console.WriteLine($"Итого: {sum + sum2}");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Электронные средства:\t\t\t\t{sum + sum2}");
//Console.WriteLine("НДС итога чека с расчитаной ставкой\n18%\t10.53");
//Console.WriteLine("НДС итога чека с расчитаной ставкой\n10%\t6.36");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("*********************************************************");
//Console.WriteLine("ВИД НАЛОГООБЛАЖЕНИЯ: ОСН");
//Console.WriteLine("РЕГ. НОМЕР ККТ: 0000143873023483");
//Console.WriteLine("ЗАВОД. №:");
//Console.WriteLine("ФН. №: 8710000100265168");
//Console.WriteLine("ФД. №: 6026");
//Console.WriteLine("ФПД: 3322278314");

//дз 6.1
//string myString = "28";
//Console.WriteLine(myString);
//byte myByte = byte.Parse(myString);
//Console.WriteLine(myByte);
//nint myNint = nint.Parse(myString);
//Console.WriteLine(myNint);
//int myInt = int.Parse(myString);
//Console.WriteLine(myInt);
//long myLong = long.Parse(myString);
//Console.WriteLine(myLong);
//double myDouble = double.Parse(myString);
//Console.WriteLine(myDouble);

// дз 6.2
//string firstString = "512";
//int number = int.Parse(firstString);
//Console.WriteLine(number.GetType());
//string secondString = number.ToString();
//Console.WriteLine(secondString.GetType());
//Console.WriteLine(secondString);

//string a = "100";
//int b = int.Parse(a);
//Console.WriteLine(b.GetType());
//string c = b.ToString();
//Console.WriteLine(c.GetType());
//Console.WriteLine(c);

//7.1-2
//1
//double PI = 3.14;
//Console.WriteLine("Введите радиус окружности: ");
//double radius = double.Parse(Console.ReadLine());
//Console.WriteLine("Площадь круга равна: ");
//Console.WriteLine(PI * radius * radius);
//2
//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.WriteLine("Введите вашу фамилию: ");
//string surname = Console.ReadLine();
//Console.WriteLine("Введите ваше отчество: ");
//string familyName = Console.ReadLine();
//Console.WriteLine("Укажите место работы: ");
//string job = Console.ReadLine();
//Console.WriteLine("Семейное положение: ");
//string familyStatus = Console.ReadLine();
//Console.WriteLine("Есть ли у вас дети: ");
//string children = Console.ReadLine();
//Console.WriteLine($"{name}\n{surname}\n{familyName}\n{job}\n{familyStatus}\n{children}");

////9.2
////1
//long a = 264895468854;
//Console.WriteLine(a + "=" + Convert.ToString(a, 2));
//Console.WriteLine(~a + "=" + Convert.ToString(~a, 2));
//long b = 256;
//Console.WriteLine(b + "=" + Convert.ToString(b, 2));
//Console.WriteLine(~b + "=" + Convert.ToString(~b, 2));
////2
//int c = 256;
//c >>= 1;
//Console.WriteLine(c);
//c <<= 1;
//Console.WriteLine(c);
////3
//int d = 289;
//d += 2487;
//Console.WriteLine(d);
//d *= 2487;
//Console.WriteLine(d);
//d -= 2487;
//Console.WriteLine(d);
//d /= 2487;
//Console.WriteLine(d);
//d %= 2487;
//Console.WriteLine(d);
//d >>= 2487;
//Console.WriteLine(d);
//d <<= 2487;
//Console.WriteLine(d);

//int g = 144;
//g += 2487;
//Console.WriteLine(g);
//g *= 2487;
//Console.WriteLine(g);
//g -= 2487;
//Console.WriteLine(g);
//g /= 2487;
//Console.WriteLine(g);
//g %= 2487;
//Console.WriteLine(g);
//g >>= 2487;
//Console.WriteLine(g);
//g <<= 2487;
//Console.WriteLine(g);

//int e = 36274;
//e += 2487;
//Console.WriteLine(e);
//e *= 2487;
//Console.WriteLine(e);
//e -= 2487;
//Console.WriteLine(e);
//e /= 2487;
//Console.WriteLine(e);
//e %= 2487;
//Console.WriteLine(e);
//e >>= 2487;
//Console.WriteLine(e);
//e <<= 2487;
//Console.WriteLine(e);

// дз 10.1

//Console.Write("Введите радиус:");
//double R = double.Parse(Console.ReadLine());
//double S = Math.PI * R * R;
//double L = 2 * Math.PI * R;
//Console.WriteLine($"Площадь окружности = {S:F2}");
//Console.WriteLine($"Длинна окружности = {L:F2}");

// дз 10.2

//Console.Write("Введите катет А: ");
//double A = double.Parse(Console.ReadLine());
//Console.Write("Введите гипотенузу C: ");
//double C = double.Parse(Console.ReadLine());
//double B = Math.Sqrt(C * C - A * A);
//Console.WriteLine($"Значение второго катета = {B:F2}");

// дз 11.1

//int a;
//double Sum = 0;
//int CountGreat10 = 0;
//int CountLess10 = 0;
//int min;
//int max;
//Console.Write("Введите 1 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//min = a;
//max = a;

//Console.Write("Введите 2 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 3 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 4 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 5 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 6 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 7 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 8 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 9 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.Write("Введите 10 число:");
//a = int.Parse(Console.ReadLine());
//Sum += a;
//CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
//CountLess10 = (a < -10) ? ++CountLess10 : CountLess10;
//if (a < min) min = a;
//if (a > max) max = a;

//Console.WriteLine("Сумма чисел = " + Sum);
//Console.WriteLine("Количество чисел больших 10 - " + CountGreat10);
//Console.WriteLine("Количество чисел меньших -10 - " + CountLess10);
//Console.WriteLine("Среднее арифметическое всех чисел = " + (Sum / 10));
//Console.WriteLine("Минимальное число: " + min);
//Console.WriteLine("Максимальное число: " + max);

//11.2

//Console.WriteLine("Введите температуру на улице: ");
//double T = double.Parse(Console.ReadLine());
//if (T < 35 && T > 20) Console.WriteLine("На улицу выходят гулять: Слоны,Жирафы,Львы.");
//else if (T > -35 && T < 20) Console.WriteLine("На улицу выходят гулять: Медведи,Волки,Пингвины.");
//else if (T == 20) Console.WriteLine("На улицу выходят гулять: Кенгуру.");
//else Console.WriteLine("Такой температуры не существует");

//11.3
//1
//Random random = new Random();
//Console.WriteLine("Введите и угадайте число от 0 до 5 загаданое компьютером:");
//int userNumber = int.Parse(Console.ReadLine());
//int number = random.Next(0, 6);
//Console.WriteLine(number);
//if (userNumber == number) Console.WriteLine("Победа!");
//else Console.WriteLine("Вы не угадали");
////2
//Console.Write("Введите номер месяца:");
//byte n = byte.Parse(Console.ReadLine());
//Console.Write("Введите температуру:");
//double t = double.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//    case 2:
//    case 12:
//        {
//            if (t > 0) Console.WriteLine("Дождьливая зима");
//            Console.WriteLine("Зима"); break;
//        }
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Такого месяца нет"); break;
//}

//11.4

//Console.WriteLine("Введите ваш возраст: ");
//int age = int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");
//Console.WriteLine("За кого отдадите свой голос?\n" + "1-Незнайка\n" + "2-Лунтик\n" + "3-Карлсон\n" + "4-Дядя Фёдор\n");
//int number = int.Parse(Console.ReadLine());
//switch (number)
//{
//    case 1: Console.WriteLine("Незнайка - А у тебя в животе арбуз вырастет!!!"); break;
//    case 2: Console.WriteLine("Лунтик - Да, я хочу летать! Я хочу, править миром!"); break;
//    case 3: Console.WriteLine("Карлсон - Спокойствие, только спокойствие!"); break;
//    case 4: Console.WriteLine("Дядя Фёдор - Чтобы продать что-нибудь не нужное, надо купить что-нибудь не нужное, а унас денег нет!"); break;
//    default: Console.WriteLine("Такого кандидата нет!"); break;
//}

//12.1
//Console.Write("Введите первое число: ");
//double n1 = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//double n2 = double.Parse(Console.ReadLine());
//Console.WriteLine("Выберете операцию:\n"+"1-Сложение\n"+"2-Вычитание\n"+"3-Умножение\n"+"4-Деление\n");
//int operation = int.Parse(Console.ReadLine());
//switch (operation)
//{
//    case 1: Console.WriteLine(n1+n2);break;
//    case 2: Console.WriteLine(n1-n2);break;
//    case 3: Console.WriteLine(n1*n2);break;
//    case 4: Console.WriteLine(n1/n2);break;
//    default: Console.WriteLine("Такой операции нет!");break;
//}

//12.2
//Console.WriteLine("Выберете аромат духов:\n" + "1-Chanel\n" + "2-Dior\n" + "3-Tom Ford\n" + "4-Gucci\n"+ "5-Yves Saint Laurent\n");
//int perfume = int.Parse(Console.ReadLine());
//switch(perfume)
//{
//    case 1:Console.WriteLine("Хороший парфюм, по приемлемой цене.");break;
//    case 2:Console.WriteLine("Летящие,ароматные запахи");break;
//    case 3:Console.WriteLine("Очень дорогой парфюм, пахнет бабками");break;
//    case 4:Console.WriteLine("Стойкий парфюм, с хорошим шлейфом");break;
//    case 5:Console.WriteLine("Достойный гурманский аромат5");break;
//    default:Console.WriteLine("В списке 5 пунктов!");break;
//}

//13.1
//Random random = new Random();
//int ran = random.Next(1, 6);
//int i = 1;
//do
//{
//    Console.Write("Введите число от 1 до 5 загаданое компьютером: ");
//    int n = int.Parse(Console.ReadLine()); i++;
//    if (ran == n)
//    {
//        Console.WriteLine("Победа!"); break;
//    }
//    else if (ran != n && i == 2)
//    {
//        Console.WriteLine("Вы не угадали, у вас еще 2 попытки.");
//    }
//    else if (ran != n && i == 3)
//    {
//        Console.WriteLine("Вы не угадали, у вас еще 1 попытка.");
//    }
//    else if (ran != n && i == 4)
//    {
//        Console.WriteLine("Вы не угадали, компьютер загадал число: " + ran);
//    }
//}
//while (i <= 3);

//13.2
//1
//Random random = new Random();
//int n;
//do
//{
//    n=random.Next(1,11);
//    Console.Write(n+" ");
//}
//while (n!=7);
//2
//int a;
//int sum = 0;
//int i = 1;
//do
//{
//    Console.WriteLine("Введите число: ");
//    a = int.Parse(Console.ReadLine());
//    sum += a;
//}
//while (a != 0);
//Console.WriteLine("Сумма чисел равна " + sum);

//14.1
//Console.WriteLine("Укажите длинну пароля: ");
//int lengthpasword =int.Parse(Console.ReadLine());
//Random random = new Random();
//int password;
//for (int i = 0; i < lengthpasword; i++)
//{
//    password = random.Next(48,123);
//    Console.Write((char) password);
//}

//14.2
//1
//Random random = new Random();
//double temperature = 0;
//for (int i = 0; ; i++)
//{
//    temperature = random.Next(1,100);
//    Console.WriteLine(temperature);
//    if (temperature>90)
//    {
//        Console.WriteLine("Устройство перегрелось.");break;
//    }
//}
//2
//Console.Write("Укажите количество квадратов: ");
//int quantity = Convert.ToInt32(Console.ReadLine());
////просим ввести пользователя колличество квадратов
//Console.Write("Укажите сторону квадрата: ");
//int weigth = Convert.ToInt32(Console.ReadLine());
////просим указать колличество звездочек из которых будет состоять квадрат
//for (int i = 0; i < quantity; i++)//вычисляется колличество повторений операции
//{
//    for (int j = 0; j < weigth; j++)//вычисляется длинна верхней стороны
//    {
//        Console.Write("*");//вывод на экран
//        Console.Write(" ");//вывод на экран
//    }
//    Console.WriteLine();
//    for (int k = 0; k < weigth - 2; k++)//длинна левой и правой сторон
//    {
//        Console.Write("*");//вывод на экран
//        for (int l = 0; l < weigth + weigth - 2; l++)
//        {
//            Console.Write(" ");//вывод на экран
//        }
//        Console.Write("*");//вывод на экран
//        Console.WriteLine();//вывод на экран
//    }
//    for (int m = 0; m < weigth; m++)// длинна нижней стороны
//    {
//        Console.Write("*");//вывод на экран
//        Console.Write(" ");//вывод на экран
//    }
//    Console.WriteLine();
//}

//15.2
//Random random = new Random();
//int[] mas = new int[10];
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(0, 9);
//    Console.Write(mas[i]);
//    if (mas[i] == 0)
//    {
//        continue;
//    }
//    if (mas[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Четных чисел в массиве {count}");

//15.1
//string[] mas = new string[12];
//mas[0] = "освоении";
//mas[1] = "остальное";
//mas[2] = "по плечу";
//mas[3] = "сложный";
//mas[4] = "но если";
//mas[5] = "программирования";
//mas[6] = "многие бросают";
//mas[7] = "остальное будет";
//mas[8] = "освоить их,";
//mas[9] = "этап в";
//mas[10] = "на этом этапе,";
//mas[11] = "Массивы -";
//Console.WriteLine(mas[11] + " " + mas[3] + " " + mas[9] + " " + mas[0] + " " + mas[5] + " " + mas[4] + " " + mas[8] + " " + mas[7] + " " + mas[2] + " " + mas[1] + " " + mas[10] + " " + mas[6]);

//15.4
//int[] mas1 = { 4, 8 };
//int[] mas2 = { 16, 2 };
//double[] masTotal1 = new double[2];
//for (int i = 0; i < mas1.Length; i++)
//{
//    masTotal1[i] = (mas1[i] + mas2[i]) / 2;
//    Console.Write($"{masTotal1[i]:F2} ");
//}
//Console.WriteLine();
//int[] mas3 = { 1, 22 };
//int[] mas4 = { 13, 3 };
//double[] masTotal2 = new double[2];
//for (int i = 0; i < mas3.Length; i++)
//{
//    masTotal2[i] = (mas3[i] + mas4[i]) / 2.0;
//    Console.Write($"{masTotal2[i]:F2} ");
//}
//Console.WriteLine();
//double[] masTotal3 = new double[2];

//for (int i = 0; i < masTotal3.Length; i++)
//{
//    masTotal3[i] = masTotal1[i] * masTotal2[i];
//    Console.Write($"{masTotal3[i]:F2} ");
//}

//15.3
//int[] mas = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    Console.Write($"Введите {i + 1}-е число: ");
//    mas[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(mas);
//foreach (int number in mas)
//{
//    Console.Write($"{number} ");
//}
//Console.WriteLine();
//Console.Write("Введите число для поиска: ");
//int searchNumber = int.Parse(Console.ReadLine());
//int index = Array.BinarySearch(mas, searchNumber);
//if (index >= 0)
//{
//    Console.WriteLine($"Число {searchNumber} найдено в массиве по индексу {index}");
//}
//else Console.WriteLine("Число не найдено в массиве");

//16.1
//1
//double[,] mas = new double[3, 3];
//int count = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        mas[i, j] = count++;
//    }
//}
//Console.WriteLine();
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Введите координаты элемента для замены (строка и столбец, разделенные пробелом):");
//string[] coordinates = Console.ReadLine().Split(' ');
//int row = int.Parse(coordinates[0]);
//int col = int.Parse(coordinates[1]);
//Console.WriteLine("Введите новое значение элемента:");
//double newValue = double.Parse(Console.ReadLine());
//mas[row - 1, col - 1] = newValue;
//Console.WriteLine();
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}

//2
//char[,] mas = new char[5, 2];
//mas[0, 0] = 'П';
//mas[0, 1] = 'р';
//mas[1, 0] = 'и';
//mas[1, 1] = 'в';
//mas[2, 0] = 'е';
//mas[2, 1] = 'т';
//mas[3, 0] = ' ';
//mas[3, 1] = 'м';
//mas[4, 0] = 'и';
//mas[4, 1] = 'р';
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.Write("Слово: Привет мир");

//16.2
//string[,] mas ={{"","","x","x","",""},
//                {"","x","","","x",""},
//                {"x","","","","","x"},
//                {"","x","x","x","x",""},
//                {"","","x","x","",""},
//                {"","","x","x","",""},
//                {"","","x","x","",""},
//                {"","","x","x","",""},
//                {"","","x","x","",""},
//                {"","","x","x","",""},
//                {"","x","x","x","x",""}};
//string answer = "нет"; bool isChecked = false; do
//{
//    Console.Clear();
//    for (int j = 0; j < mas.GetUpperBound(0) + 1; j++)
//    {
//        for (int l = 0; l < mas.GetUpperBound(1) + 1; l++)
//        {
//            if (mas[j, l] != null)
//            {
//                Console.Write($"{mas[j, l],2}");
//            }
//        }
//        Console.WriteLine();
//    }
//    if (isChecked == false) Console.Write("Включить лампочку?");
//    else Console.Write("Выключить лампочку?"); answer = Console.ReadLine()!;
//    if (answer == "да") isChecked = !isChecked; if (isChecked)
//    {
//        mas[1, 2] = "x"; mas[1, 3] = "x";
//        mas[2, 2] = "x"; mas[2, 3] = "x"; mas[2, 1] = "x"; mas[2, 4] = "x";
//    }
//    else
//    {
//        mas[1, 2] = ""; mas[1, 3] = "";
//        mas[2, 2] = ""; mas[2, 3] = ""; mas[2, 1] = ""; mas[2, 4] = "";
//    }
//}
//while (true);

//16.3.4
//Console.Write("Введите максимальное количество задач:");
//int n = int.Parse(Console.ReadLine());
//string[,] mas = new string[n, 4];
//int count = 0;//количество задач
//int number;
//bool start = true;
//string search = "";
//do
//{
//    Console.Clear();
//    Console.WriteLine($"Всего задач {n}, свободных {n - count}");
//    Console.WriteLine("Меню:");
//    Console.WriteLine("1. Добавить задачу\n" +
//        "2. Удалить задачу\n" +
//        "3. Перезаписать задачу\n" +
//        "4. Поиск\n" +
//        "5. Выход");
//    if (search != "")
//    {
//        for (int i = 0; i < count; i++)
//        {
//            if (mas[i, 0].StartsWith(search))
//                Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}" +
//                    $"{mas[i, 2],-10}{mas[i, 3],5}");
//        }
//    }
//    else
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}" +
//                $"{mas[i, 2],-10}{mas[i, 3],5}");
//        }
//    }
//    try
//    {
//        Console.Write("Введите действие:");
//        number = int.Parse(Console.ReadLine());

//        switch (number)
//        {
//            case 1:
//                {
//                    if (count < n)
//                    {
//                        Console.Write("Введите название задачи:");
//                        string name = Console.ReadLine();
//                        Console.Write("Введите дату задачи:");
//                        string date = Console.ReadLine();
//                        Console.Write("Введите время задачи:");
//                        string time = Console.ReadLine();
//                        Console.Write("Введите приоритет задачи:");
//                        string priority = Console.ReadLine();
//                        mas[count, 0] = name;
//                        mas[count, 1] = date;
//                        mas[count, 2] = time;
//                        mas[count, 3] = priority;
//                        count++;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Нет свободных мест");
//                        Console.ReadKey();
//                    }
//                }
//                break;
//            case 2:
//                {
//                    Console.Write("Введите номер задачи для удаления:");
//                    int m = int.Parse(Console.ReadLine());
//                    for (int i = 0; i < mas.GetLength(1); i++)
//                    {
//                        mas[m - 1, i] = "";
//                    }
//                }
//                break;
//            case 3:
//                {
//                    Console.Write("Введите номер задачи для изменения:");
//                    int m = int.Parse(Console.ReadLine());
//                    Console.Write("Введите название задачи:");
//                    string name = Console.ReadLine();
//                    Console.Write("Введите дату задачи:");
//                    string date = Console.ReadLine();
//                    Console.Write("Введите время задачи:");
//                    string time = Console.ReadLine();
//                    Console.Write("Введите приоритет задачи:");
//                    string priority = Console.ReadLine();
//                    mas[m, 0] = name;
//                    mas[m, 1] = date;
//                    mas[m, 2] = time;
//                    mas[m, 3] = priority;
//                }
//                break;
//            case 4:
//                {
//                    Console.Write("Введите задачу для поиска:");
//                    search = Console.ReadLine();
//                }
//                break;
//            case 5:
//                start = false;
//                break;
//            default:
//                Console.WriteLine("Введите правильное действие");
//                Console.ReadKey();
//                break;
//        }
//    }
//    catch
//    {

//    }
//}
//while (start);

//17.1
//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9, 10 };
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Введите число 200:");
//int n = int.Parse(Console.ReadLine());
//mas[1][1] = n;
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//17.2
//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9, 10 };
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        Console.Write(mas[i][j] + " ");
//    }
//    Console.WriteLine();
//}
//int[] sum = new int[mas.Length];
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        sum[i] += mas[i][j];
//    }
//}
//Console.WriteLine("Суммы одномерных массивов:");
//for (int i = 0; i < sum.Length; i++)
//{
//    Console.WriteLine(sum[i]);
//}
//int masSum = 0;
//int colMasIndex = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        masSum += mas[i][j];
//        colMasIndex++;
//    }
//}
//double avg = (double)masSum / colMasIndex;
//Console.WriteLine($"Среднее арифметическое всех значений массива: {avg}");

//18.1
//string[] forbiddenWords = { "1", "2", "3" };
//string sentence = "";
//while (true)
//{
//    Console.WriteLine("Введите слово (или 'конец' для завершения): ");
//    string word = Console.ReadLine();
//    if (word.ToLower() == "конец")
//    {
//        break;
//    }
//    bool wordIsForbidden = false;
//    foreach (string forbiddenWord in forbiddenWords)
//    {
//        if (forbiddenWord.ToLower() == word.ToLower())
//        {
//            wordIsForbidden = true;
//            break;
//        }
//    }
//    if (wordIsForbidden)
//    {
//        sentence += "(скрыто) ";
//    }
//    else
//    {
//        sentence += word + " ";
//    }
//}
//Console.WriteLine("Сформированное предложение: " + sentence);

//18.2
//1
//Console.WriteLine("Введите строку чисел, разделенных запятыми: ");
//string input = Console.ReadLine();
//string[] numbersAsStrings = input.Split(',');
//int sum = 0;
//foreach (string numberAsString in numbersAsStrings)
//{
//    if (int.TryParse(numberAsString, out int number))
//    {
//        sum += number;
//    }
//    else
//    {
//        Console.WriteLine($"Ошибка: \"{numberAsString}\" не является числом.");
//    }
//}
//Console.WriteLine($"Сумма чисел: {sum}");
//2
//Console.WriteLine("Введите предложение: ");
//string input = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//int wordCount = words.Length;
//Console.WriteLine($"Количество слов: {wordCount}");

//19.1.2.3.4
//игра пройди лабиринт
//int size = 20;
//char[,] maze = new char[size, size];
//Random random = new Random();
//Console.WriteLine("ПРИВЕТСТВУЮ ВАС В ИГРЕ ЛАБИРИНТ");
//for (int i = 0; i < size; i++)
//{
//    for (int j = 0; j < size; j++)
//    {
//        maze[i, j] = random.Next(20) < 2 ? 'Ж' : ' ';
//    }
//}
//maze[0, 0] = 'S';
//maze[size - 1, size - 1] = 'F';
//int playerX = 0, playerY = 0;
//while (true)
//{
//    for (int i = 0; i < size; i++)
//    {
//        for (int j = 0; j < size; j++)
//        {
//            Console.Write(maze[i, j]);
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine("Введите направление (w/s/a/d) или (0) для выхода: ");
//    string input = Console.ReadLine();

//    if (input == "w" && playerX > 0)
//    {
//        maze[playerX, playerY] = ' ';
//        playerX--;
//    }
//    else if (input == "s" && playerX < size - 1)
//    {
//        maze[playerX, playerY] = ' ';
//        playerX++;
//    }
//    else if (input == "a" && playerY > 0)
//    {
//        maze[playerX, playerY] = ' ';
//        playerY--;
//    }
//    else if (input == "d" && playerY < size - 1)
//    {
//        maze[playerX, playerY] = ' ';
//        playerY++;
//    }
//    else if (input == "0")
//    {
//        Console.WriteLine("До свидания!");
//        break;
//    }
//    if (maze[playerX, playerY] == 'F')
//    {
//        Console.WriteLine("Вы выйграли !!!");
//        break;
//    }
//    if (maze[playerX, playerY] == 'Ж')
//    {
//        Console.WriteLine("Вы проиграли , Не касайтесь стен !!!");
//        break;
//    }
//    maze[playerX, playerY] = '@';
//    Console.Clear();
//}

//20.1
//Console.WriteLine("Введите первое число:");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число:");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int sum = SumNumbers(number1, number2);
//Console.WriteLine($"Сумма чисел: {sum}");
//static int SumNumbers(int num1, int num2)
//{
//    return num1 + num2;
//}

//20.2
//Random random = new Random();
//int[] mas = new int[random.Next(10, 20)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(100);
//    Console.Write(mas[i] + " ");
//}
//double avg = CalculateAverage(mas);
//Console.WriteLine($"Среднее значение массива равно: {avg:F2}");
//double CalculateAverage(int[] array)
//{
//    int sum = 0;
//    foreach (int number in array)
//    {
//        sum += number;
//    }
//    double avg = (double)sum / array.Length;
//    return avg;
//}

//20.3
//Console.WriteLine("Введите 1 число: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите 2 число: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Выберете операцию производимую с числом: ");
//Console.WriteLine("1 - Логическое побитовое умножение.");
//Console.WriteLine("2 - Логическое побитовое сложение.");
//Console.WriteLine("3 - Логическое побитовое шифрование по ключу");
//Console.WriteLine("4 - Логическую побитовую инверсию");
//int choise = int.Parse(Console.ReadLine());
//switch (choise)
//{
//    case 1:
//        int resultAnd = number1 & number2;
//        Console.WriteLine("Результат побитового умножения: " + resultAnd);
//        break;
//    case 2:
//        int resultOr = number1 | number2;
//        Console.WriteLine("Результат побитового сложения: " + resultOr);
//        break;
//    case 3:
//        int resultEncryption = number1 ^ number2;
//        Console.WriteLine("Результат шифрования по ключу: " + resultEncryption);
//        break;
//    case 4:
//        int resultInversion = ~number1;
//        int resultInversion2 = ~number2;
//        Console.WriteLine("Результат инверсии первого числа: " + resultInversion);
//        Console.WriteLine("Результат инверсии второго числа: " + resultInversion2);
//        break;
//    default:
//        Console.WriteLine("Неправильный выбор!");
//        break;
//}

//20.4
//int[,] mas1 = new int[4, 4];
//int[,] mas2 = new int[4, 4];
//Console.WriteLine("Первый массив:");
//GenerateRandomMas(mas1);
//Console.WriteLine("Второй массив:");
//GenerateRandomMas(mas2);
//Console.WriteLine("Сумма массивов двух предыдущих:");
//int[,] sumMas = SumMas(mas1, mas2);
//PrintMas(sumMas);
//int max = FindMaxValue(sumMas);
//Console.WriteLine($"Максимальное значение в массиве: {max}");
//void GenerateRandomMas(int[,] mas)
//{
//    Random random = new Random();
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j] = random.Next(-50, 50);
//            Console.Write($"{mas[i, j]}" + " ");
//        }
//        Console.WriteLine();
//    }
//}
//void PrintMas(int[,] mas)
//{
//    int x = mas.GetLength(0);
//    int y = mas.GetLength(1);
//    for (int i = 0; i < x; i++)
//    {
//        for (int j = 0; j < y; j++)
//        {
//            Console.Write($"{mas[i, j]}"+" ");
//        }
//        Console.WriteLine();
//    }
//}
//int[,] SumMas(int[,] mas1, int[,] mas2)
//{
//    int x = mas1.GetLength(0);
//    int y = mas1.GetLength(1);
//    int[,] result = new int[x, y];
//    for (int i = 0; i < x; i++)
//    {
//        for (int j = 0; j < y; j++)
//        {
//            result[i, j] = mas1[i, j] + mas2[i, j];
//        }
//        Console.WriteLine();
//    }
//    return result;
//}
//int FindMaxValue(int[,] mas)
//{
//    int max = int.MinValue;
//    int x = mas.GetLength(0);
//    int y = mas.GetLength(1);
//    for (int i = 0; i < x; i++)
//    {
//        for (int j = 0; j < y; j++)
//        {
//            if (mas[i, j] > max)
//            {
//                max = mas[i, j];
//            }
//        }
//    }
//    return max;
//}

//21.1
//Console.WriteLine("Введите путь к файлу:");
//string filePath = Console.ReadLine();
//Console.WriteLine("Введите текст для записи:");
//string text = Console.ReadLine();
//try
//{
//    File.WriteAllText(filePath, text);
//    Console.WriteLine("Файл успешно записан.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
//    return;
//}
//CreateFile("Файл2.txt");
//CreateFile("Файл3.txt");
//try
//{
//    string firstFileContent = File.ReadAllText(filePath);
//    Console.WriteLine($"Содержимое первого файла:\n{firstFileContent}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
//    return;
//}
//static void CreateFile(string fileName)
//{
//    try
//    {
//        File.Create(fileName).Close();
//        Console.WriteLine($"Создан файл {fileName}.");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ошибка при создании файла {fileName}: {ex.Message}");
//    }
//}

//21.2
//Console.WriteLine("Введите путь к файлу:");
//string filePath = Console.ReadLine();
//if (File.Exists(filePath))
//{
//    Console.WriteLine("Файл существует.");
//    try
//    {
//        FileInfo fileInfo = new FileInfo(filePath);
//        Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
//        Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
//        Console.WriteLine($"Расширение файла: {fileInfo.Extension}");
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Ошибка при получении информации о файле: {ex.Message}");
//    }
//}
//else
//{
//    Console.WriteLine("Файл не существует.");
//}

//21.3
//string currentDirectory = Directory.GetCurrentDirectory();
//Console.WriteLine("Текущая директория: " + currentDirectory);
//while (true)
//{
//    Console.Write("Введите название папки, в которую необходимо перейти (или 'exit' для выхода): ");
//    string folderName = Console.ReadLine();
//    if (folderName.ToLower() == "exit")
//    {
//        break;
//    }
//    string newDirectory = Path.Combine(currentDirectory, folderName);
//    if (!Directory.Exists(newDirectory))
//    {
//        Console.WriteLine("Папка не найдена. Попробуйте снова.");
//    }
//    else
//    {
//        currentDirectory = newDirectory;
//        Directory.SetCurrentDirectory(currentDirectory);
//        Console.WriteLine("Вы перешли в директорию: " + currentDirectory);
//    }
//}

//21.4
//Console.WriteLine("Введите путь к файлу или папке для удаления:");
//string path = Console.ReadLine();

//if (File.Exists(path) || Directory.Exists(path))
//{
//    Console.WriteLine($"Вы уверены, что хотите удалить {path}? (y/n)");
//    char confirmation = Console.ReadKey().KeyChar;
//    Console.WriteLine();

//    if (confirmation == 'y' || confirmation == 'Y')
//    {
//        try
//        {
//            if (File.Exists(path))
//            {
//                File.Delete(path);
//                Console.WriteLine($"Файл {path} успешно удален.");
//            }
//            else if (Directory.Exists(path))
//            {
//                Directory.Delete(path, true);
//                Console.WriteLine($"Папка {path} успешно удалена.");
//            }
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine($"Ошибка удаления: {e.Message}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Удаление отменено.");
//    }
//}
//else
//{
//    Console.WriteLine("Файл или папка по указанному пути не найдены.");
//}
//Console.ReadLine();

//22.1
//NullReferenceException:
//Предназначение: Выбрасывается, когда программа пытается обратиться к объекту, который имеет значение null.
//Примеры ситуаций: Попытка обращения к методу или свойству объекта, который был установлен в null.
//Обработка исключения: Для предотвращения NullReferenceException следует всегда проверять объект на null 
//перед обращением к его методам или свойствам.
//ArgumentException:
//Предназначение: Выбрасывается, когда передан недопустимый аргумент методу.
//Примеры ситуаций: Передача отрицательного значения в метод, который принимает только положительные числа.
//Обработка исключения: Для обработки исключения с типом ArgumentException следует проверять переданные аргументы
//на корректность и в случае ошибки выбрасывать исключение.
//IndexOutOfRangeException:
//Предназначение: Выбрасывается, когда индекс массива или коллекции находится за пределами допустимого диапазона.
//Примеры ситуаций: Попытка доступа к элементу массива по индексу, который больше, чем длина массива.
//Обработка исключения: Для предотвращения IndexOutOfRangeException следует проверять перед доступом к элементу массива,
//что индекс находится в допустимом диапазоне.
//FileNotFoundException:
//Предназначение: Выбрасывается, когда файл не найден при попытке открыть его.
//Примеры ситуаций: Попытка открыть файл на чтение, который не существует.
//Обработка исключения: Для обработки FileNotFoundException следует предварительно проверять существование файла перед попыткой его открытия.
//DivideByZeroException:
//Предназначение: Выбрасывается, когда попытка деления на ноль.
//Примеры ситуаций: Попытка деления числа на ноль.
//Обработка исключения: Для предотвращения DivideByZeroException следует перед делением проверять знаменатель на ноль. 
//В случае деления на ноль следует обрабатывать исключение или использовать условные конструкции для предотвращения ошибки.

//22.2
//try
//{
//    Console.WriteLine("Введите список чисел, разделенных пробелами:");
//    string input = Console.ReadLine();
//    string[] numbers = input.Split(' ');
//    int sum = 0;

//    foreach (string number in numbers)
//    {
//        if (!int.TryParse(number, out int num))
//        {
//            throw new FormatException("Некорректный ввод. Пожалуйста, введите только целые числа, разделенные пробелами.");
//        }
//        sum += num;
//    }

//    Console.WriteLine($"Сумма введенных чисел: {sum}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//23.1
//1.Разница между статической и динамической памятью в программировании
//Статическая память выделяется во время компиляции и имеет фиксированный размер. Она хранит информацию, 
//которая известна во время компиляции, например, константы и переменные объявленные в классе. 
//Доступ к статической памяти осуществляется с помощью указателей, которые хранят адреса переменных.
//Динамическая память выделяется во время выполнения программы и может быть изменена по размеру в ходе выполнения. 
//Она хранит информацию, которая неизвестна во время компиляции, например, динамические массивы и объекты. 
//Доступ к динамической памяти осуществляется с помощью указателей, которые хранят адреса переменных.
//2. Тип данных, хранящийся в статической памяти, и доступ к нему в программе
//В статической памяти обычно хранятся данные, определенные во время компиляции, такие как:

//Локальные статические переменные
//Глобальные переменные
//Константы
//Строковые литералы
//Доступ к переменным в статической памяти осуществляется с помощью ссылок на них, хранящихся в указателях.

//3. Роль стека в управлении локальными переменными и вызовом функций
//Стек - это область памяти, в которой хранятся:

//Локальные переменные функций
//Аргументы функций
//Адрес возврата (для перехода на следующий оператор после возврата из функции)
//Стек работает по принципу LIFO (Last In, First Out), что означает, что последним элементом, добавленным в стек, будет и первым удаленным. 
//Управление стеком осуществляется автоматически компилятором.

//Вызов функции:

//При вызове функции в стек помещаются аргументы функции и адрес возврата.
//Локальные переменные функции выделяются в стеке.
//Выполнение функции начинается с первой инструкции.
//Возврат из функции:

//Адрес возврата извлекается из стека.
//Локальные переменные функции освобождаются из стека.
//Выполнение программы продолжается на следующем операторе после вызова функции.
//4. Принцип работы стека (LIFO) и его практическое применение
//Принцип работы стека (LIFO):

//Стек можно представить как стопку предметов, где новые предметы кладутся сверху, а старые предметы находятся внизу. 
//    Последний добавленный предмет является первым извлеченным.

//Практическое применение стека:

//Управление локальными переменными и вызовом функций
//Реализация рекурсивных вызовов
//Разбор выражений в обратной польской нотации
//Реализация динамического массива.

//23.2
//1.Понятие кучи(динамической памяти) и ее применение в программировании
//Куча - это область памяти, которая выделяется во время выполнения программы и 
//может быть изменена по размеру в ходе выполнения. Она используется для хранения данных, 
//которые неизвестны во время компиляции, например, динамические массивы и объекты.

//2. Процесс выделения и освобождения памяти в куче
//Выделение памяти:

//Программа запрашивает у операционной системы блок памяти определенного размера.
//Операционная система выделяет блок памяти в куче и возвращает его адрес программе.
//Программа использует этот адрес для доступа к выделенному блоку памяти.
//Освобождение памяти:

//Когда программа больше не нуждается в выделенном блоке памяти, она сообщает об этом операционной системе.
//Операционная система помечает этот блок памяти как свободный и может использовать его для других целей.
//3. Типы данных, которые могут храниться в куче, и управление ими
//В куче могут храниться различные типы данных, в том числе:

//Динамические массивы: Массивы, размер которых может быть изменен в ходе выполнения программы.
//Объекты: Экземпляры классов, содержащие данные и методы.
//Структуры данных: Связные списки, очереди, стеки и т.д.
//Управление памятью в куче осуществляется с помощью указателей. Указатель - это переменная, 
//которая хранит адрес другого участка памяти. Когда программе требуется доступ к данным в куче, 
//она использует указатель, хранящий адрес начала блока памяти.

//4. Проблемы при неправильном использовании динамической памяти и их избежание
//Неправильное использование динамической памяти может привести к следующим проблемам:

//Утечка памяти: Программа выделяет память в куче, но не освобождает ее, когда она больше не нужна. 
//    Это приводит к постепенному истощению памяти и может вызвать сбой программы.
//Повреждение памяти: Программа записывает данные за пределы выделенной области памяти, 
//    что может привести к непредвиденным последствиям или сбоям.
//Для предотвращения этих проблем следует придерживаться следующих правил:

//Всегда освобождайте память, которая больше не нужна.
//Инициализируйте указатели значением null, когда они не ссылаются на какую-либо область памяти.
//Используйте средства автоматического управления памятью, такие как сборщик мусора, 
//для отслеживания и освобождения неиспользуемой памяти.

//24.1
//Console.Write("Введите слово: ");
//string word = Console.ReadLine();
//bool isPalindrome = IsPalindrome(word);
//if (isPalindrome)
//{
//    Console.WriteLine("Is a palindrome");
//}
//else
//{
//    Console.WriteLine("Not a palindrome");
//}
//    static bool IsPalindrome(string word)
//{
//    if (word.Length <= 1)
//    {
//        return true;
//    }
//    if (word[0] != word[word.Length - 1])
//    {
//        return false;
//    }
//    return IsPalindrome(word.Substring(1, word.Length - 2));
//}

//24.2
//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//PrintOddNumbers(num);
//static void PrintOddNumbers(int num)
//{
//    if (num <= 0)
//    {
//        return;
//    }
//    if (num % 2 == 0)
//    {
//        Console.Write(" ");
//    }
//    else
//    {
//        Console.Write(num + " ");
//    }
//    PrintOddNumbers(num - 1);
//}

//
