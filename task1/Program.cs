// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int QP(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) res += 1;
    return res;
}

void PrintArray(int[] array)
{
    Console.Write(string.Join(", ", array));
}

int[] InputNumbers(int quantity)
{
    int res = 0;
    int[] inputNumbers = new int[quantity];
    for (int i = 0; i < inputNumbers.Length; i++)
    {
        inputNumbers[i] = GetInfo($"Введите число {i + 1}: ");
    }    
    return inputNumbers;
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int m = GetInfo("Сколько чисел вы хотите ввести?: ");
int[] inputNumbers = InputNumbers(m);
PrintArray(inputNumbers);
int quantityPositive = QP(inputNumbers);
Console.WriteLine($" -> {quantityPositive}");

