// See https://aka.ms/new-console-template for more information


using System.Reflection.PortableExecutable;
using System.Xml;



Console.WriteLine("Hello, World!");


// Desafio 1.1
// Faça uma divisão de variáveis int
// ■ Utilize números primos e apresente o resultado na tela
// ■ Repita o processo utilizando double e decimal

Console.WriteLine(divisao(1, 2));
Console.WriteLine(divisao(7, 3));
Console.WriteLine(divisao(1, 2.0));
Console.WriteLine(divisao(7, 3.0));
Console.WriteLine(divisao(1, 2.0m));
Console.WriteLine(divisao(7, 3.0m));

// Desafio 1.2
// Transforme em minúscula
// ■ Declare uma variável char maiúscula e transforme em minúscula
Console.WriteLine(transformaMinuscula('l'));
Console.WriteLine(transformaMinuscula('L'));
Console.WriteLine(transformaMinuscula('a'));
Console.WriteLine(transformaMinuscula('A'));
Console.WriteLine(transformaMinuscula('z'));
Console.WriteLine(transformaMinuscula('Z'));

// Desafio 1.3
// Declare um vetor de:
// ■ char com a, b, c
// ■ string com 1, 2, 3

char[] vetor1 = { 'a', 'b', 'c' };
string[] vetor2 = { "1", "2", "3" };

// Desafio 1.4 Declare uma Lista de int
List<int> listaDeInteiros;

// Desafio 1.5 - Converta um vetor de string para uma Lista de string
List<string> listaDeStrings = new();
foreach(string i in vetor2)
{
    listaDeStrings.Add(i);
}

// Desafio 2.1
// Concatenar, substituir ou remover strings caso exista uma determinada string
// ■ Substitua “Macaco” por “Banana”
// ■ Concatenar “Mais dinheiro será necessário“ para “estou pobre”
string frase = "O macaco saltou de galho em galho na floresta";
Console.WriteLine(frase);
frase = frase.Replace("macaco","banana");
Console.WriteLine(frase);

string frase2 = "Infelizmente, no momento, estou pobre e enfrentando dificuldades financeiras.";
Console.WriteLine(frase2);
if (frase2.Contains("estou pobre"))
{
    frase2 = frase2 + " Mais dinheiro será necessário";
}
Console.WriteLine(frase2);

// Dizer se um número é impar ou par e se for ímpar dizer se é divisível por 3
// ■ Utilizar ulong

Console.WriteLine(imparOuPar(1));
Console.WriteLine(imparOuPar(10));
Console.WriteLine(imparOuPar(15));
Console.WriteLine(imparOuPar(32));
Console.WriteLine(imparOuPar(45));
Console.WriteLine(imparOuPar(211));

// Utilize Else If para calcular o troco dado dois valores
troco(28.89m, 200.34m);


saudacao(PeriodoDia.Dia);
saudacao(PeriodoDia.Outro);

//Utilize o for para encontrar os números primos dado um valor máximo (ou range)
SieveOfEratosthenes(32);

// Utilize o while para encontrar os “valores de granizo” de um dado número

// Utilize o do while para encontrar os valores de fibonacci
sequenciaFibonacci(4);

// Utilize o foreach para, dada uma lista de strings com nomes, abreviar estes nomes
List<string> listaNomes = new();
string nome1 = "Eduardo Reisdorfer Kist Lima";
string nome2 = "Bruna Fontana Lima";
string nome3 = "Fernanda Fontana Lima";
string nome4 = "Clara Fontana Lima";
listaNomes.Add(nome1);
listaNomes.Add(nome2);
listaNomes.Add(nome3);
listaNomes.Add(nome4);

List<string> nomesAbreviados = abreviando(listaNomes);


foreach (string nome in nomesAbreviados)
{
    Console.WriteLine(nome);
}

Console.WriteLine(ehPrimo(2));
Console.WriteLine(ehPrimo(3));
Console.WriteLine(ehPrimo(32));
Console.WriteLine(ehPrimo(25));
Console.WriteLine(ehPrimo(29));
Console.WriteLine(ehPrimo(97));

List<int> granizoImpressa = listaDeGranizo(25);

foreach (int granizo in granizoImpressa)
{
    Console.WriteLine(granizo);
}

Console.WriteLine($"O IMC é {calculoImc(80f, 1.80f):F2}");

List<int> seq2 = sequenciaFibonacciLimiteSuperior(34);

foreach(int seq in seq2)
{
    Console.WriteLine(seq);
}

Pessoa pessoa1 = new();
Pessoa pessoa2 = new();
Pessoa pessoa3 = new();
Pessoa pessoa4 = new();

pessoa1.Nome = "Marcos";
pessoa1.Altura = 1.82f;
pessoa1.Peso = 80.20f;
pessoa1.DataDeNascimento = new DateTime(1978, 11, 7);
pessoa1.Sexo = 'M';

pessoa2.Nome = "Patricia";
pessoa2.Altura = 1.62f;
pessoa2.Peso = 67.00f;
pessoa2.DataDeNascimento = new DateTime(1985, 1, 17);
pessoa2.Sexo = 'F';

pessoa3.Nome = "Elaine";
pessoa3.Altura = 1.78f;
pessoa3.Peso = 50.40f;
pessoa3.DataDeNascimento = new DateTime(1992, 5, 12);
pessoa3.Sexo = 'F';

pessoa4.Nome = "Emerson";
pessoa4.Altura = 2.12f;
pessoa4.Peso = 105.10f;
pessoa4.DataDeNascimento = new DateTime(1988, 9, 10);
pessoa4.Sexo = 'M';


resultados(pessoa1, pessoa2);
resultados(pessoa3, pessoa3);
resultados(pessoa1, pessoa4);
resultados(pessoa3, pessoa4);



static T divisao<T>(T a, T b)
{
    dynamic dividendo = a;
    dynamic divisor = b;

    return dividendo / divisor;
}

static char transformaMinuscula(char c)
{
    if(c > 90)
    {
        return c;
    }

    return (char)(c + 32);
}

static string imparOuPar (int a)
{
    if (a % 2 == 0)
    {
        return "É par";
    }
    else if (a % 3 == 0)
    {
        return "É ímpar e divisível por 3";
    }
    else
    {
        return "É ímpar e não divisível por 3";
    }
}



static void troco(decimal valorTotal, decimal valorPago)
{
    decimal troco = valorPago - valorTotal;
    if (troco < 0)
    {
        Console.WriteLine("Paga direito, safado");
        return;
    }

    int notas50 = (int)(troco / 50);
    troco %= 50;

    int notas20 = (int)(troco / 20);
    troco %= 20;

    int notas1 = (int)(troco / 1);
    troco %= 1;

    int moedas10 = (int)(troco / 0.10m);
    troco %= 0.10m;

    int moedas1 = (int)(troco / 0.01m);
    
    Console.WriteLine("Troco:");
    Console.WriteLine(notas50 + " nota" + testePlural(notas50) + " de 50");
    Console.WriteLine(notas20 + " nota" + testePlural(notas20) + " de 20");
    Console.WriteLine(notas1 + " nota" + testePlural(notas1) + " ou moeda" + testePlural(notas1) + " de 1");
    Console.WriteLine(moedas10 + " moeda" + testePlural(moedas10) + " de 10 centavos");
    Console.WriteLine(moedas1 + " moeda" + testePlural(moedas1) + " de 1 centavo");

}

static string testePlural (int notaOuMoeda)
{
    if (notaOuMoeda > 1)
    {
        return "s";
    }
    else
    {
        return "";
    }
}

static void saudacao(PeriodoDia periodo)
{
    string mensagem;

    switch (periodo)
    {
        case PeriodoDia.Dia:
            mensagem = "Bom dia";
            break;
        case PeriodoDia.Tarde:
            mensagem = "Boa tarde";
            break;
        case PeriodoDia.Noite:
            mensagem = "Boa noite";
            break;
        default:
            mensagem = "É madrugada? Já?";
            break;
    }

    Console.WriteLine(mensagem);
}

static void SieveOfEratosthenes(int n)
{
    bool[] primo = new bool[n + 1];
    for (int i = 2; i <= n; i++)
    {
        primo[i] = true;
    }

    for (int divisor = 2; divisor * divisor <= n; divisor++)
    {
        if (primo[divisor] == true)
        {
            for (int i = divisor * divisor; i <= n; i += divisor)
            {
                primo[i] = false;
            }
        }
    }

    for (int divisor = 2; divisor <= n; divisor++)
    {
        if (primo[divisor])
        {
            Console.Write(divisor + " ");
        }
    }
    Console.WriteLine();
}

static void sequenciaFibonacci(int numeroValores)
{

    Console.Write("1 ");
    int primeiro = 0;
    int segundo = 1;
    int i = 2;
    
    while (i <= numeroValores)
    {
        int proximo = primeiro + segundo;
        Console.Write(proximo + " ");

        primeiro = segundo;
        segundo = proximo;

        i++;
    }
    Console.WriteLine();
}

static List<int> sequenciaFibonacciLimiteSuperior (int limiteSuperior)
{
    List<int> list = new List<int>();

    int primeiro = 0;
    int segundo = 1;

    list.Add(primeiro);

    while ((segundo + primeiro) <= limiteSuperior)
    {
        int proximo = primeiro + segundo;
        list.Add(proximo);
        primeiro = segundo;
        segundo = proximo;

    }

    return list;
}

static List<string> abreviando(List<string> nomeCheio)
{
    List<string> nomesAbreviados = new();
    foreach (string nome in nomeCheio)
    {
        string nomeAbreviado = "";
        string[] nomeSplitado = nome.Split(" ");
        int ultimoNome = nomeSplitado.Length - 1;
        nomeAbreviado = nomeSplitado[0] + " ";

        for (int i = 1; i < nomeSplitado.Length -1 ; i++)
        {
            nomeAbreviado = nomeAbreviado + nomeSplitado[i][0] + ". ";
        }

        nomeAbreviado = nomeAbreviado + nomeSplitado[ultimoNome];
        
        nomesAbreviados.Add(nomeAbreviado);
    }
    return nomesAbreviados;
}

static float calculoImc(float peso, float altura)
{
    return peso/(altura*altura);
}

static bool ehPrimo (int n)
{

    bool[] primo = new bool[n + 1];
    for (int i = 2; i <= n; i++)
    {
        primo[i] = true;
    }

    for (int divisor = 2; divisor * divisor <= n; divisor++)
    {
        if (primo[divisor] == true)
        {
            for (int i = divisor * divisor; i <= n; i += divisor)
            {
                primo[i] = false;

                if (primo[primo.Length-1] == false)
                {
                    return false;
                }
            }
        }
        
    }
    return true;
}

static List<int> listaDeGranizo (int n)
{
    List<int> granizos = new();
    granizos.Add(n);
    
    while(n > 1)
    {
        if (n%2 == 0)
        {
            n = n / 2;
            granizos.Add(n);
        }
        else
        {
            n = n * 3 + 1;
            granizos.Add(n);
        }
    }

    return granizos;
}

static bool comparaDoisSexos(Pessoa pessoa1, Pessoa pessoa2)
{
    if (pessoa1.Sexo == pessoa2.Sexo)
    {
        return true;
    }

    return false;
}

static string descricaoResultado (float imcCalculado)
{
    if (imcCalculado <= 18.5)
    {
        return "Abaixo do Peso";
    }
    else if (imcCalculado <= 24.9)
    {
        return "no Peso Ideal";
    }

    return "Acima do Peso";
}

static void comparaAltura(Pessoa pessoa1, Pessoa pessoa2)
{
    if (pessoa1.Altura != pessoa2.Altura)
    {
        float diferencaAltura = Math.Abs(pessoa1.Altura - pessoa2.Altura);
        string pessoaMaisAlta = pessoa1.Altura > pessoa2.Altura ? pessoa1.Nome : pessoa2.Nome;
        Console.WriteLine($"A pessoa mais alta é: {pessoaMaisAlta}. Diferença de altura: {diferencaAltura*100:F2}cm.");
    }
    else
    {
        Console.WriteLine("As duas pessoas têm a mesma altura");
    }
}

static void comparaPeso (Pessoa pessoa1, Pessoa pessoa2)
{
    if (pessoa1.Peso != pessoa2.Peso)
    {
        float diferencaPeso = Math.Abs(pessoa1.Peso - pessoa2.Peso);
        string pessoaMaisLeve = pessoa1.Peso < pessoa2.Peso ? pessoa1.Nome : pessoa2.Nome;
        Console.WriteLine($"A pessoa mais leve é: {pessoaMaisLeve}. Diferença de peso: {diferencaPeso:F2}kg.");
    }

    else
    {
        Console.WriteLine("As duas pessoas têm o mesmo peso");
    }
}
    
static void comparaIdade (Pessoa pessoa1, Pessoa pessoa2)
{ 
    TimeSpan diferencaIdade = pessoa1.DataDeNascimento - pessoa2.DataDeNascimento;
    int diferencaAnos = Math.Abs((int)(diferencaIdade.TotalDays / 365));
    if (diferencaAnos != 0)
    {
        string pessoaMaisNova = pessoa1.DataDeNascimento > pessoa2.DataDeNascimento ? pessoa2.Nome : pessoa1.Nome;
        Console.WriteLine($"A pessoa mais nova é: {pessoaMaisNova}. Diferença de idade: {diferencaAnos} anos.");
    }

    else
    {
        Console.WriteLine("As duas pessoas têm a mesma idade");
    }
}

static void resultados (Pessoa pessoa1, Pessoa pessoa2)
{
    if (pessoa1.Equals(pessoa2))
    {
        Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} são a mesma pessoa");
    }

    else
    {
        float imcPessoaUmCalculado = calculoImc(pessoa1.Peso, pessoa1.Altura);
        float imcPessoaDoisCalculado = calculoImc(pessoa2.Peso, pessoa2.Altura);

        if (imcPessoaUmCalculado == imcPessoaDoisCalculado)
        {
            Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} estão {descricaoResultado(imcPessoaUmCalculado)}");
        }

        else
        {
            Console.WriteLine($"{pessoa1.Nome} está {descricaoResultado(imcPessoaUmCalculado)}");
            Console.WriteLine($"{pessoa2.Nome} está {descricaoResultado(imcPessoaDoisCalculado)}");
        }

        comparaAltura(pessoa1, pessoa2);
        comparaPeso(pessoa1, pessoa2);
        comparaIdade(pessoa1, pessoa2);

        bool compara = comparaDoisSexos(pessoa1, pessoa2);

        if (compara)
        {
            Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} são do mesmo sexo => {pessoa1.Sexo}");
        }
        else
        {
            Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} não são do mesmo sexo");
        }

        bool mesmaPessoa = pessoa1.Equals(pessoa2);
    }
    Console.WriteLine();
}

enum PeriodoDia
{
    Dia,
    Tarde,
    Noite,
    Outro
}

struct Pessoa
{
    public string Nome;
    public float Altura;
    public float Peso;
    public DateTime DataDeNascimento;
    public char Sexo;

}








