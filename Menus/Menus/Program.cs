int op = 1;
while (op != 0)
{

    Console.Clear();
    Console.WriteLine("Bem vindo! Escolha uma das seguintes opções:");
    Console.WriteLine("1-Opção A");
    Console.WriteLine("2-Opção B");
    Console.WriteLine("3-Opção C");
    Console.WriteLine("4-Entrar no Submenu");
    Console.WriteLine("0-Sair");
    op = int.Parse(Console.ReadLine());

    if (op == 0)
    {
        break;
    }
    else if (op == 1)
    {
        Console.Clear();
        Console.WriteLine("Opção A selecionada");
        Console.ReadKey();
    }
        
    else if (op == 2)
    {
        Console.Clear();
        Console.WriteLine("Opção B selecionada");
        Console.ReadKey();
    }
    else if (op == 3)
    {
        Console.Clear();
        Console.WriteLine("Opção C selecionada");
        Console.ReadKey();
    }
    else if(op == 4)
    {
        Submenu();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opção inválida");
        Console.ReadKey();
    }
       
}

void Submenu()
{
    int op = 1;
    while (op != 0)
    {

        Console.Clear();
        Console.WriteLine("Submenu");
        Console.WriteLine("1-Opção A");
        Console.WriteLine("0-Voltar ao menu principal");
        op = int.Parse(Console.ReadLine());

        if (op == 0)
        {
            break;
        }
        else if (op == 1)
        {
            Console.Clear();
            Console.WriteLine("Opção A do submenu selecionada");
            Console.ReadKey();
        }
    }
}