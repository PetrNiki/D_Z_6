// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2;
Console.WriteLine("Введите числа через пробел");
int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int Nambers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine(Nambers(array));
