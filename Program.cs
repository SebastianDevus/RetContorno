int altura, largura, espacoVazioHorizontal, espacoVazioVertical;

Console.Clear();
Console.WriteLine("Insira as dimensões do retângulo.");

Console.Write("Altura...:");
altura = Convert.ToInt32(Console.ReadLine());
Console.Write("Largura..:");
largura = Convert.ToInt32(Console.ReadLine());

espacoVazioHorizontal = largura - 2;
espacoVazioVertical = altura - 2;

for (int iTudo = 1; iTudo <= altura; iTudo++)
{
    if (iTudo == 1 || iTudo == altura)
    {
        for (int iLargura = 1; iLargura <= largura; iLargura++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    else
    {
        Console.Write("*");

        for (int iVazio = 1; iVazio <= espacoVazioHorizontal; iVazio++)
        {
            Console.Write(" ");
        }

        Console.Write("*");
        Console.WriteLine();
    }
}
Console.WriteLine("\nSucesso!\n");