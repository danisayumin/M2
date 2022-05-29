double menuinicial, opcao, garantia, carro, preco, garantiaesten, valtotal;
string carro1;
carro1 = "";
preco = 0;
garantia = 2;

    Console.WriteLine("DESEJA INICIAR O PROGRAMA?\n1 - SIM\n2 - NÃO");
    menuinicial = double.Parse(Console.ReadLine());
    Console.Clear();
while (menuinicial == 2)
{
    Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE");
    Console.ReadKey();
    break;
}
while (menuinicial != 1 && menuinicial != 2)
{
    Console.WriteLine("CÓDIGO INVÁLIDO \nDIGITE NOVAMENTE UM CÓDIGO VÁLIDO \n1 - INICIAR PROGRAMA \n2 - FECHAR");
    menuinicial = double.Parse(Console.ReadLine());
    Console.Clear();
    while (menuinicial == 2)
    {
        Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE");
        Console.ReadKey();
        break;
    }
}
while (menuinicial == 1)
{
    Console.WriteLine("BEM VINDO À CONCESSIONÁRIA CALHAMBEQUE\n\nESCOLHA UMA OPÇÃO: \n1 - COMPRAR CARRO \n2 - NOTA FISCAL");
    opcao = double.Parse(Console.ReadLine());
    Console.Clear();
    while (opcao != 2 && opcao != 1)
    {
        Console.WriteLine("ESCOLHA UMA OPÇÃO VÁLIDA\n");
        break;
    }

    while (opcao == 1)
    {
        Console.Write("QUAL CARRO VOCÊ DESEJA COMPRAR? ");
        Console.WriteLine("\n1 - CIVIC 2020   R$ 90.000\n2 - COROLA 2020  R$ 95.000\n3 - KWID         R$ 60.000\n4 - PALIO FIRE   R$ 45.000");
        carro = double.Parse(Console.ReadLine());
        Console.Clear();
        while (carro != 1 && carro != 2 && carro != 3 && carro != 4)
        {
            Console.WriteLine("CÓDIGO INVÁLIDO!!!DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
            Console.WriteLine("\n1 - CIVIC 2020   R$ 90.000\n2 - COROLA 2020  R$ 95.000\n3 - KWID         R$ 60.000\n4 - PALIO FIRE   R$ 45.000");
            carro = double.Parse(Console.ReadLine());
            Console.Clear();
        }
        switch (carro)
        {
            case 1:
                carro1 = "CIVIC 2020";
                preco = 90.000;

                break;
            case 2:
                carro1 = "COROLA 2020";
                preco = 95.000;
                break;
            case 3:
                carro1 = "KWID";
                preco = 60.000;
                break;
            case 4:
                carro1 = "PALIO FIRE";
                preco = 45.000;
                break;


        } 
        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA?\n1 - SIM \n2 - NÃO");
        garantia = double.Parse(Console.ReadLine());
        Console.Clear();

        while (garantia != 1 && garantia != 2)
        {
            Console.WriteLine("CÓDIGO INVÁLIDO!DIGITE UM CÓDIGO VÁLIDO");
            Console.Write("DESEJA INCLUIR GARANTIA ESTENDIDA?\n1 - SIM \n2 - NÃO");
            garantia = double.Parse(Console.ReadLine());
            Console.Clear();
        }
        Console.WriteLine("OBRIGADO PELA COMPRA!!!");
        Console.WriteLine("DESEJA VOLTAR AO MENU INICIAL?\n1 - SIM\n2 - NÃO");
        menuinicial = double.Parse(Console.ReadLine());
        Console.Clear();
        break;

    }
    garantiaesten = preco * 10 / 100;
    valtotal = preco + garantiaesten;
    while (opcao == 2)
    {
        while(garantia == 1)
        {

            Console.WriteLine($"O produto comprado foi :{carro1}");
            Console.WriteLine($"O valor do carro foi: R$ {preco.ToString("F3")}");
            Console.WriteLine($"Possui garantia estendida? SIM");
            Console.WriteLine($"O valor da garantia estendida é R$ {garantiaesten.ToString("F3")}");
            Console.WriteLine($"Valor total da nota: R$ {valtotal.ToString("F3")}");
            break;
        }
        while(garantia == 2)
        {
            Console.WriteLine($"O produto comprado foi :{carro1}");
            Console.WriteLine($"O valor do carro foi: R$ {preco.ToString("F3")}");
            Console.WriteLine($"Possui garantia estendida? NÃO");
            Console.WriteLine($"Valor total da nota: R$ {valtotal.ToString("F3")}");
            break;
        }
        Console.WriteLine("OBRIGADO PELA COMPRA!!!");
        Console.WriteLine("DESEJA VOLTAR AO MENU INICIAL?\n1 - SIM\n2 - NÃO");
        menuinicial = double.Parse(Console.ReadLine());
        break;
    }
    while (menuinicial == 2)
    {
        Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE");
        Console.ReadKey();
        break;
    }
    while (menuinicial != 1 && menuinicial != 2)
    {
        Console.WriteLine("CÓDIGO INVÁLIDO \nDIGITE NOVAMENTE UM CÓDIGO VÁLIDO\n\nDESEJA VOLTAR AO MENU INICIAL?\n1 - SIM\n2 - NÃO");
        menuinicial = double.Parse(Console.ReadLine());
        Console.Clear();
        while (menuinicial == 2)
        {
            Console.WriteLine("OBRIGADO POR COMPRAR NA CONCESSIONÁRIA CALHAMBEQUE");
            Console.ReadKey();
            break;
        }
    }
}
