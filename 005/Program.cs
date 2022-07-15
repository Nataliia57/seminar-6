// пользователь должен ввести некоторое ко-во чисел
// нужно посчитать сколько чисел больше 0 ввел пользователь

void Zadacha41()
{
Console.WriteLine("введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите четвертое целое число: ");
int number4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пятое целое число: ");
int number5 = Convert.ToInt32(Console.ReadLine());

int count = 0;

if (number1 > 0)
{
count++;
}
if (number2 > 0)
{
    count++; 
}
if (number3 > 0)
{
    count++; 
}
if (number4 > 0)
{
    count++; 
}
if (number5 > 0)
{
    count++; 
}
Console.WriteLine(count);
 
 }

Zadacha41();