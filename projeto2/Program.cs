//importando class
using projeto2.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "deb";
pessoa1.Idade = 25;
pessoa1.Sobrenome= "macedo";
pessoa1.Apresentar();

//Metodo datatime
DateTime dataActual = DateTime.Now;
Console.WriteLine(dataActual);
Console.WriteLine(dataActual.ToString("dd/MM/yyyy"));

// diferença entre Convert e Parse convert quando o valor é null retuna 0 e parse fecha o programa
int a = Convert.ToInt32("5");
int b = int.Parse("5");
int inteiro = 5;
string c = inteiro.ToString();
int m = int.MaxValue;

// conversão segura
string f = "15-";
int g = 0;
int.TryParse(f, out g);

//espera comando no console
//System.Console.WriteLine("digite uma leta");

