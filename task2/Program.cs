// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x+b1=k2*x+b2  (k1-k2)*x=b2-b1   x=(b2-b1)/(k1-k2)

double FindX(double b1, double k1, double b2, double k2)
{
    return (b2 - b1)/(k1 - k2);
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.WriteLine("Для расчета системы уравнений y=k1*x+b1, y=k2*x+b2 введите значения: ");
double b1 = GetInfo("Введите b1: ");
double k1 = GetInfo("Введите k1: ");
double b2 = GetInfo("Введите b2: ");
double k2 = GetInfo("Введите k2: ");

double x = FindX(b1, k1, b2, k2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {k1 * x + b1})");