using System;
using System.IO;

namespace Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
           string produto;
           double preco;
           bool formaDePagamento;
           double resultado;
           double precoFinal;

           Console.WriteLine("Digite o nome do produto:");
           produto = Console.ReadLine();

           Console.WriteLine("Digite o preço do produto:");
           
           preco = double.Parse(Console.ReadLine());

           Console.WriteLine("O Pagamento Será em Dinheiro?");
           formaDePagamento = bool.Parse(Console.ReadLine());
           
           if(formaDePagamento==true){
               resultado = preco * 10/100;
               precoFinal = preco-resultado;
           }
           else{
               resultado = preco * 5/100;
               precoFinal = preco+resultado;
           }

           StreamWriter arquivo = new StreamWriter("dados.txt");

           arquivo.WriteLine("O produto escolhido foi: "+produto);
           arquivo.WriteLine("O preco do produto é: "+preco);
           arquivo.WriteLine("O valor de desconto ou acréscimo é: "+resultado);
           arquivo.WriteLine("O preço final do produto é: "+precoFinal);
           arquivo.Close();




           Console.WriteLine("O produto escolhido foi: "+produto);
           Console.WriteLine("O preco do produto é: "+preco);
           Console.WriteLine("O valor de desconto ou acréscimo é: "+resultado);
           Console.WriteLine("O preço final do produto é: "+precoFinal);







        

        }
    }
}
