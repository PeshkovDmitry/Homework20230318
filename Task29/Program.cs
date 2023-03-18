// Задача 29. Напишите программу, которая будет создавать массив из 8 символов
// и заполнять значениями от пользователя
void GetArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"Введите элемент {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.Clear();
Console.Write("Сколько ячеек будет в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
GetArray(array);
Console.WriteLine($"[{String.Join(", ",array)}]");