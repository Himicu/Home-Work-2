// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

void CheckForNegativ(int a, int b){
int result = a - b;
if(result < 0){
    Console.WriteLine("Нет пересечений");
} else if(result == 0){
    Console.WriteLine($"Пересечение в точке {a}");
} else Console.WriteLine($"пересечение в точках ({b},{a})");

}
int x1 = new Random().Next(-1000, 1000);
int x2 = new Random().Next(-1000, 1000);
int x3 = new Random().Next(-1000, 1000);
int x4 = new Random().Next(-1000, 1000);

if(x1 > x2){
    (x1, x2) = (x2, x1);
}
if(x3 > x4){
    (x3, x4) = (x4, x3);
}
Console.WriteLine($"Получились координаты: ({x1}, {x2}) ({x3}, {x4})");
if(x1 < x3){
    if(x2 < x4){
        CheckForNegativ(x2, x3);
    } else{
   CheckForNegativ(x4 ,x3);
    }
}else if(x2 < x4){
    CheckForNegativ(x2, x1);
}else {
    CheckForNegativ(x4, x1);
}
