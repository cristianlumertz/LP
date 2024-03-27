using System.Runtime.InteropServices;
using System.Security.AccessControl;

//string nome = "Paulo";
//int idade = 17;
//double nota = 7.5;

//Console.WriteLine($"{nome}, tem {idade} anos e {nota} de nota");
//Console.WriteLine($"{nome}\n{idade}\n{nota}");

//Para qual tipo de dados você pode converter um float implicitamente ?
//( ) int
//(x) double
//( ) long
//(x) decimal 
 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// (x) double para long
// (x) double para float
// (x) decimal para float
// (x) long para int
// (x) double para decimal
 

//Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
// Console.WriteLine("Digite uma letra: ");
//  char a = Convert.ToChar(Console.ReadLine());
//  Console.WriteLine("Digite uma letra: ");
//  char b = Convert.ToChar(Console.ReadLine());
//  Console.WriteLine("Digite uma letra: ");
//  char c = Convert.ToChar(Console.ReadLine());

// Console.WriteLine($"{0} {1} {2}", c, b, a); 

//Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
//(F) long resultado = 1.32;
//(V) var nome = “Maria”;
//(V) string resultado = 100.ToString();
//(V) A sequência de escape \n inclui uma nova linha
//(F) float f = 5.45;
//(V) decimal valor = (decimal) 10.99f;
//(F) var status = null;
//(V) object o = 12.45m;
//(V) string titulo = true.ToString();
//(F) A sequencia \t inclui uma tabulação vertical
 

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
// Console.WriteLine("Insira o valor do numero x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Insira o valor de numero y: ");
// double y = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Soma de {x} + {y} = {x+y}");
// Console.WriteLine($"Subtracao de {x} - {y} = {x-y}");
// Console.WriteLine($"Multiplicacao de {x} * {y} = {x*y}");
// Console.WriteLine($"Divisao de {x} / {y} = {x/y}");
// Console.WriteLine($"Modulo de {x} % {y} = {x%y}");
// Console.WriteLine($"Potencia de {x} elevado a {y} = {Math.Pow (x, y)}");


//Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)

// Console.WriteLine("Insira seu login: ");
// string nome = Console.ReadLine();
// Console.WriteLine("Insira sua senha: ");
// int senha = Convert.ToInt32(Console.ReadLine()); 
// string autorizado = (nome == "maria" || nome == "admin") && (senha == 123)
//? "Login feito com sucesso"
//: "Login invalido";
// Console.WriteLine(autorizado);

//Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

// Console.WriteLine("Insira o primeiro numero: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insira o segundo numero: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// string modulo1 = (num1%2==0)
//?"O primeiro numero e par."
//:"O primeiro numero e impar";
// Console.WriteLine(modulo1);

// string modulo2 = (num2%2==0) ?  "O primeiro numero e par." : "O primeiro numero e impar";
// Console.WriteLine(modulo2);