// See https://aka.ms/new-console-template for more information
// Создать свой класс исключения, выводящий сообщение об ошибке и текущюю дату.
// Использовать его в теле следующей программы
// Вводят число А и В. В случае если чило А не делится на число В без 
// остатка, выдать сообщение об ошибке.
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());

try
{
    if (A % B != 0)
    {
        throw new MyException("Не делится без остатка"); }
    else Console.WriteLine("делится без остатка");
    
}
catch (MyException e)
{
    Console.WriteLine(e.TimeExcept);
    Console.WriteLine(e.Message);
    //вывод стека трассировки
    
}