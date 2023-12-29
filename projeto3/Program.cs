
//operadores lógicos e condicionais
int quantidadeEmEstoque = 2;
int quantidadeCompra =4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"quantidade compra: {quantidadeCompra}");
Console.WriteLine($"é possivel vender: {possivelVenda}");

if (quantidadeCompra ==0){
    System.Console.WriteLine("venda negada");
}
else if (possivelVenda){
    Console.WriteLine("venda realizada");
}
else{
    System.Console.WriteLine("venda negada");
}

System.Console.WriteLine("digite uma letra");
//string letra = Console.ReadLine();
string letra = "a";
switch (letra){  
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        System.Console.WriteLine("vogal");
        break;
    default:
    System.Console.WriteLine("não é vogal");
    break;
}

if( letra =="a"||
    letra =="e"||
    letra =="i"||
    letra =="o"||
    letra =="u"){
        System.Console.WriteLine("vogal");
    }
else{
    System.Console.WriteLine("não é vogal");
}