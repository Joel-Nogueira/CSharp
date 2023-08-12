// See https://aka.ms/new-console-template for more information

using System;

void ExibirNumeroSeForPar(int numero)
{
    bool ehPar = (numero % 2) == 0;
    if (ehPar)
    {
        Console.WriteLine(numero);
    }
}

void ExibirLista()
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    

    Console.WriteLine("FOR");
    for (int i = 0; i < numeros.Count; i++)
    {
        ExibirNumeroSeForPar(numeros[i]);
    }

    Console.WriteLine();
    Console.WriteLine("FOREACH"); 

    foreach (int numero in numeros)
    {
        ExibirNumeroSeForPar(numero);
    }
}

ExibirLista();