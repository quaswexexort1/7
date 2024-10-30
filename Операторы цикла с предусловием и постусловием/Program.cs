try
{
    Console.WriteLine("Введите последовательность чисел(Введите 0 для завершения ввода)");
    int first = 1;
    int second;
    do
    {
        second = int.Parse(Console.ReadLine());
        if (second != 0)
        {
            first *= second;
        }
    } while (second != 0);

    Console.WriteLine($"Произведение чисел: {first}");
}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
}