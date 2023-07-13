// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Coordinata(string message)// Этот медод для того, чтобы не писать Console.ReadLine несколько раз
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);// Запрашивает у пользователя данные
    return num;// возвращает их обратно нам в работу
}

double Distance(int a, int b, int c, int d)
{
    double distance = Math.Sqrt((a - c) * (a - c) + (b - d) * (b - d));
    return distance;
}

int x1 = Coordinata("Введите первую координату точки 1: ");
int y1 = Coordinata("Введите первую координату точки 1: ");
int x2 = Coordinata("Введите первую координату точки 2: ");
int y2 = Coordinata("Введите первую координату точки 2: ");

//double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));// Решение без второго метода 
Console.WriteLine("Расстоение между точками: " + Math.Round(Distance(x1, y1, x2, y2), 3));// вывод сразу подставляет в метод данные и выводим в консоле
//и через Math.Round(число, 3) округляем до 3-х знаков после запятой.

