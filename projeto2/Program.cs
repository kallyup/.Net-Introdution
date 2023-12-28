using projeto2.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "deb";
pessoa1.Idade = 25;
pessoa1.Apresentar();

DateTime dataActual = DateTime.Now;
Console.WriteLine(dataActual);
Console.WriteLine(dataActual.ToString("dd/MM/yyyy"));
