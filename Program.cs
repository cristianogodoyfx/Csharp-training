using Exemplo_fundamentos.Models;

int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}




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

