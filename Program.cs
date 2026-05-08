Console.Write("Me Fale a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
if (idade >= 18)
{
   Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Voce e maior de idade, pode entrar na boate kiss.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Voce e menor, sai daqui moleque");
}

Console.ResetColor();
Console.WriteLine("Obrigado!");