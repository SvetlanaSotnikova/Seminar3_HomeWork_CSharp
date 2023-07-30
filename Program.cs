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
void Polindrom(int num) {
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
Polindrom(num);


// Task 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84



// Task 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125
