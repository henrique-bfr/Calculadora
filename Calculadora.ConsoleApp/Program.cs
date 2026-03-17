using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Intrinsics.Arm;

string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0;

while (true == true)
{

    Console.Clear();

    Console.WriteLine("--------------------------");
    Console.WriteLine("    Calculadora 2026");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico");
    Console.WriteLine("S - Sair");
    Console.WriteLine("--------------------------");
    Console.Write("Escolha uma opção válida: ");
    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")
    {
        break;
    }

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("OPÇÃO INVÁLIDA!");

        Console.WriteLine("DIGITE ENTER PARA SAIR");

        Console.ReadLine();
        return;
    }

    if (opcao == "5")
    {
        Console.Clear();

        Console.WriteLine("--------------------------");
        Console.WriteLine("TABUADA");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Digite um número inteiro: ");
        string strNumeroDigitado = Console.ReadLine();

        int numeroDigitado = Convert.ToInt32(strNumeroDigitado);

        Console.WriteLine(numeroDigitado);

        for (int iterador = 1; iterador <= 10; iterador = iterador + 1)
        {
            string linhaTabuada = $"{numeroDigitado} x {iterador} = {numeroDigitado * iterador}";
            Console.WriteLine(linhaTabuada);
        }


        Console.Write("Digite ENTER para continuar");
        Console.ReadLine();
        continue;

    }
    if (opcao == "6")
    {
        Console.Clear();

        Console.WriteLine("--------------------------");
        Console.WriteLine("HISTORICO");
        Console.WriteLine("--------------------------");

        for (int iterador = 0; iterador < historicoOperacoes.Length; iterador++)
        {
            if (historicoOperacoes[iterador] != null)
            {
                Console.WriteLine(historicoOperacoes[iterador]);
            }

        }

        Console.Write("Digite ENTER para continuar");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();

    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado = 0;
    string textoOperacoes = "";

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        textoOperacoes = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }
    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        textoOperacoes = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }

    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        textoOperacoes = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }

    else if (opcao == "4")
    {
        resultado = primeiroNumero / segundoNumero;
        textoOperacoes = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacoes;
        contadorOperacoes++;
    }

    else
    {
        Console.WriteLine("Escolha uma opção válida");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();
}
