int []numeros = new int[10];


for (int i = 0; i < 10; i++)
{
    numeros[i] = int.Parse(Console.ReadLine()) ;
}

Console.WriteLine("São pares: ");

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("São impares: ");

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("Primeiro e último valor: ");

for (int i = 0; i < 10; i++)
{
    if (i == 0 || i == 9)
    {
        Console.WriteLine(numeros[i]);
    }
}