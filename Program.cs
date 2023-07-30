// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
/*
Console.Write("Your num: ");
string num = Console.ReadLine();

int len = num.Length;
if (len == 5) {
    if ((num[0] == num[4]) && (num[1] == num[3])) {
        Console.Write($"{num} -> Yes");
    } else {
        Console.Write($"{num} -> No");
    }
} else {
    Console.Write("Error");
} */

// Task 19 решение с помощью функции и цикла, и для всех чисел // не без помощи интернета (GPT)
/*
void Palindrom(int num) {
    string numStr = num.ToString();
    int left = 0;
    int right = numStr.Length - 1; // -1 чтобы получить последний объект в строке так как индексация начинается с 0 //без этого не получалось
    
    while (left < right) {
        if (numStr[left++] != numStr[right--]) {
            Console.WriteLine($"{numStr} -> No");
            return;
        } 
        left++;
        right--;
    }
    Console.WriteLine($"{numStr} -> Yes");

}
Console.Write("your num: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
*/

// Task 19 решение с сокращенным вариантом, то есть сокращение кода // не без помощи интернета 
/*
bool Palindrom(int num) {
    string numStr = num.ToString();
    int left = 0;
    int right = numStr.Length - 1; 
    
    while (left < right && numStr[left] == numStr[right]) { // тоже инет помог
        left++;
        right--;
    }
    return left >= right;
}
Console.Write("your num: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} -> {(Palindrom(num) ? "Yes" : "No")}"); // нашла конструкцию в интернете 
*/

//// bool MassivPolindrom(int num) {
////     string numStr = num.ToString();
////    int[] massiv = new int[numStr.Length];
//// }

// Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
/*
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x1 - x2;
    double deltaY = y1 - y2;
    double deltaZ = z1 - z2;

    return Math.Sqrt((Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2)));
}
Console.Write("x1 = ");
double X1 = Convert.ToInt32(Console.ReadLine()); // or ToDouble()
Console.Write("Y1 = ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
double Z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2 = ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double distanse = Math.Round(GetDistance(X1, Y1, Z1, X2, Y2, Z2),2);
Console.WriteLine($"A ({X1},{Y1},{Z1}); B ({X2},{Y2},{Z2}) -> {distanse}");
*/

// Task 21 Сокращенный вариант
/*
double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
}
string[] list = { "X1", "Y1", "Z1", "x2", "Y2", "Z2" };
double[] val = new double[6];

int i = 0;

while (i < list.Length)
{
    Console.Write($"{list[i]} = ");
    val[i] = Convert.ToInt32(Console.ReadLine()); // or ToDouble()
    i++;
}

double distanse = Math.Round(GetDistance(val[0], val[1], val[2], val[3], val[4], val[5]), 2);
Console.WriteLine($"A ({val[0]},{val[1]},{val[2]}); B ({val[3]},{val[4]},{val[5]}) -> {distanse}");
*/

// Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
/*
void GetCub(int N) {

    Console.Write($"{N} -> ");
    int index = 1;

    while (index <= N) {
        double res = Math.Pow(index, 3);
        Console.Write($"{res}");

        if (index < N) {
            Console.Write(", ");
        }

        index++;
    }
}
Console.Write("Your N: ");
int N = Convert.ToInt32(Console.ReadLine());

GetCub(N); */

// Task 23 Сокращенный вариант
/*
void GetCub(int N)
{
    Console.Write($"{N} -> ");
    int index = 1;

    while (index < N)
    {
        Console.Write($"{Math.Pow(index++, 3)}, ");
    }
    Console.Write($"{Math.Pow(index, 3)}"); // Последний элемент не печатаем запятой после него
}
Console.Write("Your N: ");
int N = Convert.ToInt32(Console.ReadLine());

GetCub(N);
*/
