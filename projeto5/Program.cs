using System.Diagnostics.Contracts;

int numero = 10;

for(int contador = 0 ; contador<=numero; contador++){
    System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
int contador1=0;
while(contador1 <= numero){
    System.Console.WriteLine($"{numero} x {contador1} = {numero * contador1}");
    contador1++;
}

int soma = 0, num = 0;

do{
    System.Console.WriteLine("digite um nuemro(0 para parar)");
    //num = Convert.ToInt32(Console.ReadLine());
    soma += num;
} while(num !=0);

System.Console.WriteLine($"total da somo dos numeros é {soma}");
