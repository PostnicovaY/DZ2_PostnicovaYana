﻿// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > -100 && number < 100){
    Console.Write("Tретьей цифры нет");
}
else{
// if нужен только при условии, что мы хотим чисто цифру получить, без отрицательного значения,
// если все же нужно было показать отрицательное значение второй цифры, то просто убрать if
if (number < 0){
    number = number * -1;
}

while (number < -999 || number > 999){
    number /= 10;
}
int result = number % 10;
Console.Write(result);
}
