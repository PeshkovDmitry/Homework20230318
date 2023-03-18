// Задача 29. Напишите программу, которая будет создавать массив из 8 символов
// и заполнять значениями от пользователя
void GetArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"Введите элемент {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Clear();
int[] array = new int[8];
GetArray(array);
Console.WriteLine($"[{String.Join(", ",array)}]");