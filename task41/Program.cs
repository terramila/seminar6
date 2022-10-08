/*Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ 
ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
Console.Clear();
Console.Write("Введите число: ");
int length = int.Parse(Console.ReadLine());
Console.Write($"Введите {length} чисел от -100 до 100 через пробел, затем нажмите Enter: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
/*Main(args);

  void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
 
        Console.WriteLine(string.Join(" ",arr));
 
        Console.ReadKey();
    }*/
 


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(count);

