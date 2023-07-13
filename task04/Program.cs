// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int GetNumber(string message)// Этот медод для того, чтобы не писать Console.ReadLine несколько раз
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);// Запрашивает у пользователя данные
    return num;// возвращает их обратно нам в работу
}

void Square(int num)//Печатаем квадраты числа от 1 до N
{
int count = 1;
while (count <= num)
{
        if (count == num)
        
            Console.Write(count * count + ".");
        
        else
            Console.Write(count * count + ",");
    count++;
        
    ;
}}
int N = GetNumber("Введите число: ");
Square(N);





