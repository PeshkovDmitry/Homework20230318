// Задача 27. Напишите программу, который принимает на вход 
// число и выдает сумму цифр в числе
int Sum(int x) {
    int res = 0;
    if (x>0) {
        while (x > 0) {
            res += x%10;
            x /= 10;
        }
    } 
    return res;
}
Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} -> {Sum(n)}");