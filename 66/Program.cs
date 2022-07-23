//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int Sum(int m, int n, int sum)
{
    if (m<=n) sum = Sum(m+1,n,sum+m);
    return sum;
}
Console.WriteLine("Введите M и N. N должно быть больше M");
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
if (m>n) 
{
    Console.WriteLine("N должно быть больше M");
    return;
};
Console.WriteLine($"Сумма всех натуральных элементов от {m} до {n} = {Sum(m,n,0)}");
