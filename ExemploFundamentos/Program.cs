using Exemplo_fundamentos.Commom.Models;

Pessoa pessoa1 = new Pessoa();


/* string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    System.Console.WriteLine("Digite a sua opção: ");
    System.Console.WriteLine("1 - Cadastrar cliente: ");
    System.Console.WriteLine("2 - Cadastrar cliente: ");
    System.Console.WriteLine("3 - Apagar cliente: ");
    System.Console.WriteLine("4 - Encerrar: ");

    opcao = Console.ReadLine();

    switch(opcao)
    {
       case "1":
            System.Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            System.Console.WriteLine("Busca de cliente");
            break;
        case "3":
            System.Console.WriteLine("Apagar cliente");
            break;
        case "4":
            System.Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
        
    }

}

System.Console.WriteLine("Programa está se encerrando."); */

/* int soma = 0, numero = 0;

do
{
    System.Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

System.Console.WriteLine($"Total da soma dos números digitados é: {soma}");
 */

/* int numero = 5;
int contador = 0;

while(contador <= 10)
{
    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
} */

/* int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
} */




/* Calculadora calc = new Calculadora();

calc.RaizQuadrada(9);


 */


/* int NumeroIncremento = 10;
int NumeroDecremento = 20;

System.Console.WriteLine(NumeroIncremento);
System.Console.WriteLine("Incrementando o 10");
NumeroIncremento++;
System.Console.WriteLine(NumeroIncremento);

System.Console.WriteLine(NumeroDecremento);
System.Console.WriteLine("Decrementando o 20");
NumeroDecremento--;
System.Console.WriteLine(NumeroDecremento); */




//Calculadora calc = new Calculadora();



/* calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30); */

//calc.Potencia(3, 3);

/* calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2); */









/* System.Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        System.Console.WriteLine("Vogal");
        break;

    default:
        System.Console.WriteLine("Não é uma vogal");
        break;
}
 */










/* if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    System.Console.WriteLine("Vogal");
}
else
{
    System.Console.WriteLine("Não é vogal");
}
 */













/* int quantidadeEmEstoque = 3;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada");
}
 */





/* string a = "15-";

int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!!!"); */






// DateTime DataAtual = DateTime.Now;

/* Pessoa p = new Pessoa();

p.Nome = "Cris";
p.Idade = 26;
p.Apresentar(); */

