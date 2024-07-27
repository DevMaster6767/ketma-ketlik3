//1.Tub sonlar:
Console.Write("Iltimos, bir son kiriting=> ");
int son1 = Convert.ToInt32(Console.ReadLine());
if (son1 <= 1)
{
    Console.WriteLine($"{son1} tub emas");
}
else if (son1==2)
{
    Console.WriteLine($"{son1} tub");
}

else if (son1%2==0)
{
    Console.WriteLine($"{son1} tub emas");
}
for (int i = 3; i < son1; i += 2)
    {
        if (son1 % i == 0)
        {
            Console.WriteLine($"{son1} tub emas");
            break;
        }
        else 
        {
            Console.WriteLine($"{son1} tub ");
            break;
        }        
    }
Console.WriteLine();

//2.Bo'luvchisiz sonlar:
Console.Write("Sonni kiriting=> ");
int son2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Bo'luvchilari: ");
for (int i = 2; i <= 10; i++)
{
    if (son2 % i == 0)
    {
        Console.Write(i+" ");
    }
}
Console.WriteLine();

//3.Daraja hisoblash:
Console.Write("Sonni kiriting=> ");
double son3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Darajani kiriting (musbat, butun son)=> ");
int daraja = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{son3} ning {daraja}-darajasi; {Math.Pow(son3, daraja)}");
Console.WriteLine();

//4.Harajatlar to'plamini hisoblash:
Console.Write("To'plam miqdorlar sonini kiriting (vergul bilan ajrating)=> ");
string input = Console.ReadLine();        
string[] numbers = input.Split(',');
int sum = 0;
foreach (string num in numbers)
    {
        sum += Convert.ToInt32(num.Trim());
    }
Console.WriteLine("Yig'indisi: " + sum);
Console.WriteLine();

//5.Armstrong sonlar: 
Console.Write("Iltimos, bir son kiriting=> ");
int son4 = Convert.ToInt32(Console.ReadLine());
int raqamlarSoni = 0, sum1=0, haqiqiySon;
haqiqiySon=son4;
while (haqiqiySon != 0)
{
    haqiqiySon /=10;
    raqamlarSoni++;
}
haqiqiySon=son4;
while (haqiqiySon != 0)
{
    sum1 += (int)Math.Pow((haqiqiySon % 10), raqamlarSoni);
    haqiqiySon /=10;
}
if (sum1==son4)
{
    Console.WriteLine("Armstrong son");
}
else
{
    Console.WriteLine("Armstrong son emas");
}
Console.WriteLine();

//6.Sifatli bo'luvchilar:
Console.Write("Sonni kiriting=> ");
int son5 = Convert.ToInt32(Console.ReadLine());
int k =0;
for (int i = 1; i < son5/2; i++)
{
    if (son5 % i == 0)
    {
        k++;
    }
}
Console.WriteLine($"Sifatli bo'luvchilari {k} ta");