// У нас есть график, где даны отрезок 1 -  (х1; x2) и отрезок 2 (х3, x4)
// 	​Необходимо составить код, который находит их пересечение.
// 	Пересечением двух отрезка 1 и 2 могут быть  - отрезок, точка или ничего
// 	С клавиатуры вводим х1, x2, х3, x4 и выводим ответ - границы пересечений отрезков, общую точку или «не пересекаются».

Console.WriteLine("Введите первые координаты: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторые координаты: ");
int x3 = Convert.ToInt32(Console.ReadLine());
int x4 = Convert.ToInt32(Console.ReadLine());

int result = 0;

if(x1 > x2){
    (x1, x2) = (x2, x1);
}
if(x3 > x4){
    (x3, x4) = (x4, x3);
}
if(x1 < x3){
    if(x2 < x4){
        result = x2 - x3;
    } else{
    result = x4 -x3;
    }
}else result = x4 - x1;

if(result <=0 ){
    Console.WriteLine("Отрезки не пересекаются");
}else Console.WriteLine(result);