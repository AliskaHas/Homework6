// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



void Main()
{   
    System.Console.Write("Введите размер массива, который будете вводить: ");
    int M = int.Parse(Console.ReadLine());
           int count = 0;
    for(int i = 0; i < M; i++)
    {
        System.Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        if(number > 0)
        {
            count++;
        }
    }

    System.Console.WriteLine($"Количество чисел больше ноля: {count}");
}




//-------------------основная часть кода-----------------

Main();




