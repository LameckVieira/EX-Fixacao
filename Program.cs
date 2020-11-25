using System;

namespace EX_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Exercício 1");


            // Console.WriteLine("Digite o ano atual");
            // int anoAtual =int.Parse(Console.ReadLine());

            // Console.WriteLine("Digite o seu ano de nascimento");
            // int anoDeNacimento = int.Parse(Console.ReadLine());


            // int idade = anoAtual - anoDeNacimento;
            // Console.WriteLine(idade);

            // if(idade>16){
            //     Console.WriteLine("Você pode votar!");
            // }else{
            //     Console.WriteLine("Você não pode votar ainda!");
            // }

            // Console.WriteLine("Exercício 2");

            // Console.WriteLine("Selecione um tipo de Combustível");
            // Console.WriteLine("A - Álcool");
            // Console.WriteLine("G - Gasolina");
            // String combustivel = Console.ReadLine();

            // Console.WriteLine("Digite a quantidade de combustível");
            // float quantidadedeCombustivel = float.Parse(Console.ReadLine());
            
            
            // float percDesconto, desconto;
            // float precoAlcool = 4.9f;
            // float precoGasolida = 5.3f;
            // float valorTotal;

            // switch (combustivel.ToLower())
            // {
            //     case "a":
            //         if(quantidadedeCombustivel>20){
            //             percDesconto = 0.05f;
            //         }else{
            //             percDesconto = 0.03f;
            //         }
            //         valorTotal = (quantidadedeCombustivel * precoGasolida);
            //         desconto = (quantidadedeCombustivel * precoAlcool) * percDesconto;
            //         Console.WriteLine($"Valor a ser pago{valorTotal-desconto}");
            //         break;
            //     case "g":
            //         if(quantidadedeCombustivel>20){
            //             percDesconto = 0.05f;
            //         }else{
            //             percDesconto = 0.03f;
            //         }
            //         valorTotal = (quantidadedeCombustivel * precoGasolida);
            //         desconto = (quantidadedeCombustivel * precoGasolida) * percDesconto;
            //         Console.WriteLine($"Valor a ser pago{valorTotal-desconto}");
            //         break;
            //     default:
            //         Console.WriteLine("Opção inválida");
            //         break;
            // }
            // Console.WriteLine("Exercício 3");

            // Console.WriteLine("Exercício 4");
            // int[] n = new int [10];

            // int maiorValor, menorValor;
            // maiorValor = 0;
            // menorValor = 0;
            // Console.WriteLine("Digite 10 números:");
            // for (var i = 0; i < 10; i++)
            // {
            //     n[i] = int.Parse(Console.ReadLine());
            // }
            // for (var i = 0; i < 10; i++)
            // {
            //    if(n[i] > n[0] && n[i] > n[1] && n[i] > n[2] && n[i] > n[3] && n[i] > n[4] && n[i] > n[5] && n[i] > n[6] && n[i] > n[7] && n[i] > n[8] && n[i] > n[9])
            //    {
            //         maiorValor = n[i];
            //    }
            // }   
            // for (var i= 0; i < 10; i++)
            // {
            //     if(n[i] < n[0] && n[i] > n[1] && n[i] < n[2] && n[i] < n[3] && n[i] < n[4] && n[1] < n[5] && n[i] < n[6] && n[i] < n[7] && n[i] < n[8] && n[i] < n[9])
            //     {
            //         menorValor = n[i];
            //     }

            // } 
            // Console.WriteLine($"O maior valor é {maiorValor} e o menor valor é {menorValor}");

            // Console.WriteLine("Exercício 5");
            // Console.WriteLine("Qual tabuada deseja?");
            // int tabuada = int.Parse(Console.ReadLine());

            // for (int n = 1; n <= 10; n++)
            // {
            //     for(int i = 1; i <= 10; i++)
            //     {
            //         Console.WriteLine(n + "x" + i + "=" + n*i);
            //     }
            //     Console.WriteLine();
            // }
            // Console.ReadLine();

            Console.WriteLine("Exercício 6");

            string[] nomes = new string[10]
            string nome;

            for(var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite um nome:");
                nomes[i] = Console.ReadLine();
            }

        }
    }
}
