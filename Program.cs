void Zadacha25()
{
    Console.Write("Введите первое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int stepen = 1;
    for (int i = 1; i <= number2; i++)
    {
        stepen *= number;
    }
    Console.WriteLine(number + "^" + number2 + "=" + stepen);

} 
void Zadacha27()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /=10;
    }
    Console.WriteLine("Сумма цифр: " + sum);
}
void Zadacha29()
{
    int size = 8;
    Random random = new Random();
    int[] array = new int[size]; 
    Console.WriteLine("Текущий массив ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
        Console.Write(array[i] + "  "); 
    }
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив ");
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
        }

        int temp = array [i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        Console.Write(array[i] + "  ");
    }

}
Zadacha29();