Random rnd = new Random();
int numero = 0;

do
{
    Console.WriteLine("Escolha um número de 1 a 100.");
    numero = int.Parse(Console.ReadLine());

    if (numero == rnd.Next(1, 101))
    {
        Console.WriteLine("Parabéns, você acertou!");
    }
    else
    {
        Console.WriteLine("Você errou o número");
    }

    Console.WriteLine($"{rnd.Next(1, 101)}");
}
while ( numero != -1 );