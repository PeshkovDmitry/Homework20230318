// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В
int Pow(int x, int y) {
    int res = 1;
    for(int i = 0; i < y; i++) {
        res *= x;
    }
    return res;
}

Console.Clear();
Console.Write("Введите А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите В:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}, {b} -> {Pow(a,b)}");
