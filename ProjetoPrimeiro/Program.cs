
using System.Text.Encodings.Web;
using System.Collections.Generic;
using System.Runtime.InteropServices;

List<String> listaBandas = new List<String> { "Beatles", "Mala Sem Alça", "Desejo de Menina" };

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("Seja Bem-Vindo! Ao Screen Sound de Bandas");
}
void ExibirOpçoes()
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
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarTodasBandas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opção" + escolhido1);
            break;
        case -1:
            Console.WriteLine("Volte sempre!");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
}
void RegistrarBandas()
{

    Console.Clear(); // limpa o console com o clear
    ExibirTitulodasOpçoes("Registrado das Bandas: ");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);
    Console.WriteLine($"A banda: {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçoes(); // volta para o menu de opcoes 
}
void MostrarTodasBandas()
{
    Console.Clear();
    ExibirTitulodasOpçoes("Exibindo todas as bandas registradas: ");
    //for (int i = 0; i < listaBandas.Count; i++)
    //{
    //Console.WriteLine($"Banda: {listaBandas[i]}");
    //}
    foreach (string banda in listaBandas) // para cada banda listada na lista de bandas, exiba a banda
    {
        Console.WriteLine($"Banda : {banda}");
    }
    Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoes();
}

ExibirLogo();
ExibirOpçoes();
void ExibirTitulodasOpçoes(string titulo)
{
    int quantLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

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

    if (posicao < 3)
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
    int numeroSorteado = 15;

    do
    {
        Console.WriteLine("Digite um numero de 1 a 100: ");
        int chute = int.Parse(Console.ReadLine());

        if (chute == numeroSorteado)
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

void CalcularDuasVariaveis()
{
    Console.WriteLine("Digite o valor de A:");
    double A = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de B:");
    double B = double.Parse(Console.ReadLine());
    Console.WriteLine($"A soma de A + B = {A + B}");
    Console.WriteLine($"A subtração de A - B = {A - B}");
    Console.WriteLine($"A multiplicação de A vezes B = {A * B}");
    if (B != 0)
    {
        Console.WriteLine($"A divisao de A sobre B = {A / B}");
    }
    else
    {
        Console.WriteLine("Não é possivel dividir por 0!");
    }








}
CalcularDuasVariaveis();

List<string> exercicios = new List<string>();

exercicios.Add("Desejo de menina");
exercicios.Add("Cypher");
exercicios.Add("Poesia acustica");
for (int i = 0; i < exercicios.Count; i++)
{
    Console.WriteLine(exercicios[i]);
}


void ListaElementos()
{
    List<int> soma = new List<int> { 10, 5, 20, 24 };
    int numeros = 0;
    for (int i = 0; i < soma.Count; i++)
    {
        numeros += soma[i];

    }
    Console.WriteLine($"A soma da lista é : {numeros}");
}
ListaElementos();

List<int> number = new List<int> { 1, 2, 3, 4, 5, };
for (int i = 0; i < number.Count; i++)
{
    if (number[i] % 2 == 0)
    {
        Console.WriteLine(number[i]);
    }
}
foreach (int numero in number)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}
Console.ReadKey();
