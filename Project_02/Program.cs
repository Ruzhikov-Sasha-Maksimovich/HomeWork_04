int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 35);
    return array;
}
int PrintFirstArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count = count + array[i];
        System.Console.Write(count + ", ");
        count = count - count;
    }
    return count;
}
void PrintProdaction(int[] array)
{
    string printProdaction =" ";
    if (array.Length > 4)
    {
        printProdaction = "изначальный массив -> конечный массив";
        System.Console.WriteLine(printProdaction);
    }

    else if(array.Length < 5 && array.Length > 3)
    {
        printProdaction = "изначальный -> конечный";
        System.Console.WriteLine(printProdaction);
    }
    else if(array.Length < 4 && array.Length > 2)
    {
        printProdaction = "начальный -->  конечный";
        System.Console.WriteLine(printProdaction);
    }
    else
    {
        System.Console.WriteLine("начало -> конец");
    }
}
int rnd = new Random().Next(2, 6);
int[] array = new int[rnd];
NewArray(array);
PrintProdaction(array);
PrintFirstArray(array);
System.Console.Write("-> ");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");