// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < -999 || number > -100 && number < 100 || number > 999){
    Console.Write("Введите трехзначное число ");
    number = Convert.ToInt32(Console.ReadLine());
}

// if нужен только при условии, что мы хотим чисто цифру получить, без отрицательного значения,
// если все же нужно было показать отрицательное значение второй цифры, то просто убрать if
if (number < 0){
    number = number * -1;
}
int result = (number % 100) / 10;
Console.Write(result);
