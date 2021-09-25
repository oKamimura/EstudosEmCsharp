using System;

namespace EstudosEmCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
             //ex 23
            int codigo, quantidadeComprada, preco;
            double precoTotal, precoDesconto;
            Console.WriteLine("Digite qual o código do produto comprado:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produto comprado:");
            quantidadeComprada = int.Parse(Console.ReadLine());
            
            if (codigo <= 10){
                Console.WriteLine("O preço unitário do produto é R$10,00");
                precoTotal = quantidadeComprada * 10;
                Console.WriteLine("O preço total ficou R$" + precoTotal);
                if (precoTotal < 250){
                    Console.WriteLine("Voçe possui um desconto de 5%");
                    precoDesconto = precoTotal * 0.05 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else if (precoTotal < 500){
                    Console.WriteLine("Voçe possui um desconto de 10%");
                    precoDesconto = precoTotal * 0.10 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else{
                    Console.WriteLine("Voçe possui um desconto de 15%");
                    precoDesconto = precoTotal * 0.15 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
            }else if (codigo<=20){
                Console.WriteLine("O preço unitário do produto é R$15,00");
                precoTotal = quantidadeComprada * 15;
                Console.WriteLine("O preço total ficou R$" + precoTotal);
                 if (precoTotal < 250){
                    Console.WriteLine("Voçe possui um desconto de 5%");
                    precoDesconto = precoTotal * 0.05 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else if (precoTotal < 500){
                    Console.WriteLine("Voçe possui um desconto de 10%");
                    precoDesconto = precoTotal * 0.10 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else{
                    Console.WriteLine("Voçe possui um desconto de 15%");
                    precoDesconto = precoTotal * 0.15 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
            }else if (codigo<=30){
                Console.WriteLine("O preço unitário do produto é R$20,00");
                precoTotal = quantidadeComprada * 20;
                Console.WriteLine("O preço total ficou R$" + precoTotal);
                 if (precoTotal < 250){
                    Console.WriteLine("Voçe possui um desconto de 5%");
                    precoDesconto = precoTotal * 0.05 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else if (precoTotal < 500){
                    Console.WriteLine("Voçe possui um desconto de 10%");
                    precoDesconto = precoTotal * 0.10 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else{
                    Console.WriteLine("Voçe possui um desconto de 15%");
                    precoDesconto = precoTotal * 0.15 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
            }else if (codigo <=40){
                Console.WriteLine("O preço unitário do produto é R$30,00");
                precoTotal = quantidadeComprada * 30;
                Console.WriteLine("O preço total ficou R$" + precoTotal);
                 if (precoTotal < 250){
                    Console.WriteLine("Voçe possui um desconto de 5%");
                    precoDesconto = precoTotal * 0.05 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else if (precoTotal < 500){
                    Console.WriteLine("Voçe possui um desconto de 10%");
                    precoDesconto = precoTotal * 0.10 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
                else{
                    Console.WriteLine("Voçe possui um desconto de 15%");
                    precoDesconto = precoTotal * 0.15 + precoTotal;
                    Console.WriteLine("O preço final fica R$ " + precoDesconto);
                }
            }else{
                Console.WriteLine("Codigo invalido!");
            }
            Console.ReadKey();
        }
    }
}
