
using System.Text.Encodings.Web;
using System.Collections.Generic;

List<String> listaBandas = new List<String> { "Beatles", "Mala Sem Alça", "Desejo de Menina" };
void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("Seja Bem-Vindo!");
}
void ExibirOpções()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda:");
    Console.WriteLine("Digite 2 para mostrar todas as bandas:");
    Console.WriteLine("Digite 3 para avaliar uma banda:");
    Console.WriteLine("Digite 4 para exibir a média de uma banda:");
    Console.WriteLine("Digite -1 para sair:");

    Console.Write("\nDigite a sua opção: ");
    string escolhido = Console.ReadLine()!;
    int escolhido1 = int.Parse(escolhido);
    switch (escolhido1)
    {
        case 1: Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case 2: Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case 3: Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case 4: Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case -1: Console.WriteLine("Volte sempre!");
            break;
        default: Console.WriteLine("Opção invalida!");
            break;
    }
}
ExibirMensagemBoasVindas();
ExibirOpções();
void ExibirMedia()
{

    Console.WriteLine("Digite  valor da nota : ");
    int notaMedia = int.Parse(Console.ReadLine());
    
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
}
void listLinguagem()
{
List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
    Console.WriteLine("\nLista de Linguagens: ");
    Console.WriteLine(linguagens);

    Console.WriteLine("Digite a posição: ");
    int posicao = int.Parse(Console.ReadLine());

    if(posicao < 3)
    {
        Console.WriteLine($"{linguagens[posicao]}");
    }
    else
    {
        Console.WriteLine("Valor incorreto!");
    }

}
ExibirMedia();
listLinguagem();

void jogoAleatorio()
{
    int numeroSorteado = 15 ;
    
    do
    {
        Console.WriteLine("Digite um numero de 1 a 100: ");
        int chute = int.Parse(Console.ReadLine());

        if(chute == numeroSorteado)
        {
            Console.WriteLine("Parabéns voce acaba de acertar!");
            break;
        }
        else if (chute > numeroSorteado)
        {
            Console.WriteLine("O numero é menor! ");
        }
        else
        {
            Console.WriteLine("O numero é maior!");
        }
    } while (true);
    Console.WriteLine("O jogo acabou!");

}
    Random aleatorio = new Random();
    int numeroSorteado = aleatorio.Next(1, 101);

jogoAleatorio();
Console.ReadKey();
