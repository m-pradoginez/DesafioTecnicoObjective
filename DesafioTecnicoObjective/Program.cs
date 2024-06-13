var keyPressed = " ";
List<string> pratoList = new List<string>();
List<string> tipoPratoList = new List<string>();
string prato = "";
int count = 0;

while (keyPressed != "")
{
    Console.Write("Pense em um prato que gosta. (Pressione ENTER para continuar) ");
    keyPressed = Console.ReadLine();

    if (keyPressed != "")
    {
        Console.WriteLine("Erro: Entrada Inválida. (Pressione ENTER para continuar)");
        Console.WriteLine();
    }

    Console.Write("O prato que você pensou é massa? (sim/não) ");
    keyPressed = Console.ReadLine().ToLower();

    if (keyPressed == "sim")
    {
        Console.Write("O Prato que você pensou é lasanha? (sim/não) ");
        keyPressed = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (keyPressed == "sim")
        {
            Console.WriteLine("Acertei de novo!");
        }
        else
        {
            Console.Write("Qual prato você pensou? ");
            pratoList.Add(Console.ReadLine().ToLower());
            prato = pratoList.Last();
            Console.WriteLine();

            Console.Write(prato + " é ____ mas Lasanha não.");
            tipoPratoList.Add(Console.ReadLine().ToLower());
            Console.WriteLine();
            count++;
        }

        Console.WriteLine();
    }
    else
    {
        if (count != 0)
        {
            foreach (var item in tipoPratoList)
            {
                Console.Write("O prato que você pensou é " + item + " (sim/não) ");
                keyPressed = Console.ReadLine().ToLower();
            }

            if (keyPressed == "não")
            {
                goto Bolo;
            }

            Console.Write("O prato que você pensou é " + prato + " (sim/não) ");
            keyPressed = Console.ReadLine().ToLower();

            if (keyPressed == "sim")
            {
                Console.WriteLine("Acertei de novo!");
            }
        }

    Bolo:
        Console.Write("O prato que você pensou é Bolo de Chocolate? (sim/não) ");
        keyPressed = Console.ReadLine().ToLower();

        if (keyPressed == "sim")
        {
            Console.WriteLine("Acertei de novo!");
        }
        else
        {
            Console.Write("Qual prato você pensou? ");
            pratoList.Add(Console.ReadLine().ToLower());
            prato = pratoList.Last();
            Console.WriteLine();

            Console.Write(prato + " é ____ mas Bolo de Chocolate não. ");
            tipoPratoList.Add(Console.ReadLine().ToLower());
            Console.WriteLine();
            count++;
        }
    }
}