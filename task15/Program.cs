// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// решение через массив и проверки

string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.Write("Укажите номер дня недели: ");
int weakDay = Convert.ToInt32(Console.ReadLine());

if (weakDay > 0 && weakDay < 8)
{
    if (weakDay > 5)
    {
        for (int x = 0; x < day.Length; x++)
        {
            if (x + 1 == weakDay)
            {
                Console.Write($"День недели выходной");
                
            }
        }
    }
    else
    {
        Console.Write($"День недели не выходной");
    }

}
else{
    Console.Write($"Недопустимое значение");
}

//упрощенное решение без массива, без всего

Console.Write("Укажите номер дня недели: ");
int weakDay1 = Convert.ToInt32(Console.ReadLine());

if (weakDay1 > 0 && weakDay1 < 8){
    if(weakDay1 > 5){
        Console.Write("День недели выходной");
    }
    else Console.Write("День недели не выходной");
}
else Console.Write("Недопустимое значение");

