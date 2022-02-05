
//1.Antes do racionamento de energia ser decretado, quase ninguém falava em quilowatts; mas, agora, todos
//incorporaram essa palavra em seu vocabulário.
//
//Sabendo-se que 100 quilowatts de energia custa um sétimo do
//salário mínimo, fazer um algoritmo que receba o valor do salário mínimo e a quantidade de quilowatts gasta
//por uma residência e calcule. Imprima:
//• O valor em reais de cada quilowatt
//• O valor em reais a ser pago
//• O novo valor a ser pago por essa residência com um desconto de 10%



//Console.WriteLine("Insira o sálario mínimo");
//double minimo = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Insira a quantidade de KwH gastos nesse mês!");
//double kw = Convert.ToDouble(Console.ReadLine());

//double custo = minimo / 7 / 100;

//Console.WriteLine($"Cada kw custa " + custo + " reais");
//Console.WriteLine($"O valor a ser pago é de " + custo * kw + " reais");
//Console.WriteLine($"Com desconto de 10% o total fica " + custo * kw / 10 * 9 + " reais ");

//Console.ReadKey();



//2. Em época de pouco dinheiro, os comerciantes estão procurando aumentar suas vendas oferecendo
//desconto.Faça um algoritmo que possa entrar com o valor de um produto e imprima o novo valor tendo em
//vista que o desconto foi de 9%


//Console.WriteLine("Insira o valor do produto");
//double valorProduto = Convert.ToDouble(Console.ReadLine());

//double percentual = 9.0 / 100.0; 
//double valor_final = valorProduto - (percentual * valorProduto);

//Console.WriteLine($"O valor do seu produto com desconto ficou em " +valor_final+" reais");
//Console.ReadKey();

using System;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Criar um algoritmo que efetue o cálculo do salário líquido de um professor.
            //Os dados fornecidos serão: valor
            //da hora aula, numero de aulas dadas no mês e percentual de desconto do INSS.


            //  Console.WriteLine("Insira o valor da hora aula!");
            //  double valorHoraAula = Convert.ToDouble(Console.ReadLine());
            //
            //  Console.WriteLine("Insira a quantidade de aulas dadas no mês!");
            //  double qtdAulas = Convert.ToInt64(Console.ReadLine());
            //
            //  double salarioBruto = valorHoraAula * qtdAulas;
            //
            //  var calculo75 = salarioBruto * 7.5 / 100;
            //  var calculo9 = salarioBruto * 9 / 100;
            //  var calculo12 = salarioBruto * 12 / 100;
            //  var calculo14 = salarioBruto * 14 / 100;
            //
            //  if (salarioBruto <= 1212)
            //      Console.WriteLine($"Salario liquido: " + (salarioBruto - calculo75));
            //  else if (salarioBruto <= 2427)
            //      Console.WriteLine($"Salario liquido: " + (salarioBruto - calculo9));
            //  else if (salarioBruto <= 3641)
            //      Console.WriteLine($"Salario liquido: " + (salarioBruto - calculo12));
            //  else 
            //      Console.WriteLine($"Salario liquido: " + (salarioBruto - calculo14));
            //
            //


            //4.Todo restaurante, embora por lei não possa obrigar o cliente a pagar, cobra 10 % para o garçom.
            //Fazer um algoritmo que leia o valor gasto com despesas realizadas em um restaurante e imprima o valor total com
            //gorjeta.



            //   Console.WriteLine("Insira o valor da comanda!");

            //   double valorComanda = Convert.ToDouble(Console.ReadLine());

            //   var taxaGarcom = valorComanda * 10 / 100;

            //   var valorFinal = taxaGarcom + valorComanda;

            //   Console.WriteLine($"O valor total com a taxa do garçom ficou em: " + valorFinal, "reais");


            //5. Uma pessoa resolveu fazer uma aplicação em uma poupança programada. Para calcular seu rendimento, ela
            //  devera fornecer o valor constante da aplicação mensal, a taxa e o número de meses. Sabendo - se que a
            //    formula usada para este calculo é:
            //      Valor acumulado = P * ((1 + i)n - 1)/ i
            //        i = taxa
            //          P = aplicação mensal
            //            n = número de meses(obs. (1 + i) elevado a n)


            //   Console.WriteLine("Insira o valor da aplicação!");
            //   double valorAplicacao = Convert.ToDouble(Console.ReadLine());
            // 
            //   Console.WriteLine("Insira a taxa!");
            //   double taxa = Convert.ToDouble(Console.ReadLine());
            // 
            //   Console.WriteLine("Insira o tempo em meses!");
            //   double meses = Convert.ToDouble(Console.ReadLine());
            // 
            //   double ValorAcumulado = valorAplicacao * ((1 + taxa)* meses - 1) / taxa;         
            //   Console.WriteLine(ValorAcumulado);




            //6. Entrar com um número e imprimi-lo caso seja maior que 20.

            //  Console.WriteLine("Insira um número!");
            //    var numero = Convert.ToInt64(Console.ReadLine());
            //
            //  if (numero > 20)
            //      Console.WriteLine(numero);
            //  else
            //      Console.WriteLine("O número informado não é maior que 20!");


            // 7.Construir um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja
            //    maior que 10, apresentá - lo.

            //   Console.WriteLine("Insira o primeiro número!");
            //   var numero1 = Convert.ToInt64(Console.ReadLine());
            //
            //   Console.WriteLine("Insira o segundo número!");
            //   var numero2 = Convert.ToInt64(Console.ReadLine());
            //
            //   var somaNumero = numero1 + numero2;
            //
            //   if (somaNumero > 10)
            //       Console.WriteLine("O resultado é " + somaNumero);
            //   else
            //       Console.WriteLine();



            // 8. Construir um algoritmo que leia dois números e efetue a adição.Caso o valor somado seja maior que 20,
            //  este devera ser apresentado somando - se a ele mais 8; caso o valor somado seja menor ou igual a 20, este
            //   devera ser apresentado subtraindo - se 5.

            //    Console.WriteLine("Insira o primeiro número!");
            //      var numero1 = Convert.ToInt64(Console.ReadLine());
            //    
            //      Console.WriteLine("Insira o segundo número!");
            //      var numero2 = Convert.ToInt64(Console.ReadLine());
            //    
            //      var somaNumero = numero1 + numero2;
            //
            //    if (somaNumero > 20)
            //    {
            //        somaNumero = somaNumero + 8;
            //        Console.WriteLine("O resultado é " + somaNumero);
            //    }
            //
            //    else
            //    {
            //        somaNumero = somaNumero - 5;
            //        Console.WriteLine("O resultado é " + somaNumero);
            //
            //    }

            // 9. A prefeitura do Rio de Janeiro abriu uma linha de crédito para os* funcionários estatutários. O valor Máximo
            //da prestação não poderá ultrapassar 30 % do salário bruto. Fazer um programa que permita entrar com o
            // salário bruto e o valor da prestação e informa se o empréstimo pode ou não ser concedido.

            //   Console.WriteLine("Insira o salario bruto!");
            //   double salarioBruto = Convert.ToDouble(Console.ReadLine());
            //  
            //   Console.WriteLine("Insira o valor da prestação!");
            //   double valorPrestacao = Convert.ToDouble(Console.ReadLine());
            //  
            //   var porcentagem =  salarioBruto * 0.3;
            //   
            //   if (porcentagem > valorPrestacao)
            //   {
            //       Console.WriteLine("Seu emprestimo pode ser concedido!");
            //   } else
            //   {
            //       Console.WriteLine("Seu emprestimo não pode ser concedido!");
            //   }
            //   Console.ReadKey();





            // 10.Construir um algoritmo que indique se o número digitado esta compreendido entre 20 e 90 ou não.


            //  Console.WriteLine("Insira um número!");
            //       var numero = Convert.ToInt64(Console.ReadLine());
            //
            //  if (numero >= 20 && numero < 90)
            //  {
            //  Console.WriteLine("O número está entre 20 e 90!");
            //
            //  }
            //  else
            //  {
            //      Console.WriteLine("O número não está entre 20 e 90!");
            //  }


            // 11.Entrar com um número e imprimir uma das mensagens: maior do que 20, igual a 20 ou menor do que 20


            // Console.WriteLine("Insira um número!");
            // var numero = Convert.ToInt64(Console.ReadLine());
            //
            // if (numero > 20)
            // {
            //     Console.WriteLine("O número é maior que 20!");
            //
            // }
            // else if (numero == 20)
            // {
            //     Console.WriteLine("O número é igual a 20!");
            // }
            // else
            // {
            //     Console.WriteLine("O número é menor que 20!");
            // }
            // Console.ReadKey();


            //12. Entrar com nome, sexo e idade de uma pessoa. Se a pessoa for do sexo feminino e tiver menos que 25
            // anos, imprimir nome e a mensagem: ACEITA.Caso contrário, imprimir nome e a mensagem: NÃO ACEITA

            //   Console.WriteLine("Insira seu nome!");
            //   string nome = Console.ReadLine();
            //  
            //   Console.WriteLine("Insira seu sexo!");
            //   string sexo = Console.ReadLine();
            //  
            //   Console.WriteLine("Insira sua idade!");
            //   var idade = Convert.ToInt64(Console.ReadLine());
            //
            //
            //   if (sexo == "feminino" && idade < 25) {
            //       Console.WriteLine("ACEITA");
            //   } else
            //   {
            //       Console.WriteLine("NÃO ACEITA");
            //   }

            // 13.  Entrar com a sigla do estado de uma pessoa imprimir uma das mensagens:
            //   • Carioca
            //   • Paulista
            //   • Mineiro
            //   • Outros estados

            //Console.WriteLine("Insira a Sigla!");
            //string sigla = Console.ReadLine();
            //
            //
            //switch (sigla)
            //{
            //    case "rj":
            //        Console.WriteLine("Carioca!");
            //        break;
            //    case "sp":
            //        Console.WriteLine("Paulista!");
            //        break;
            //    case "mg":
            //        Console.WriteLine("Mineiro!");
            //        break;
            //    default:
            //        Console.WriteLine("Outros Estados!");
            //        break;
            //}

            //14.Criar um algoritmo que leia dois números e imprimir uma mensagem dizendo se são iguais ou diferentes


            //   Console.WriteLine("Insira o primeiro número!");
            //   var numero1 = Convert.ToInt64(Console.ReadLine());
            //
            //   Console.WriteLine("Insira o segundo número!");
            //   var numero2 = Convert.ToInt64(Console.ReadLine());
            //
            //
            //   if (numero1 == numero2)
            //   {
            //       Console.WriteLine("Os números sao iguais!");
            //   } else
            //   {
            //       Console.WriteLine("Os números sao diferentes!");
            //   }


            // 15.Entrar com dois números e imprimir o maior numero(suponha números diferentes).

            //  Console.WriteLine("Insira o primeiro número!");
            //  var numero1 = Convert.ToInt64(Console.ReadLine());
            //
            //  Console.WriteLine("Insira o segundo número!");
            //  var numero2 = Convert.ToInt64(Console.ReadLine());
            //
            //  if (numero1 > numero2)
            //  {
            //      Console.WriteLine(numero1);
            //  } else if (numero1 == numero2)
            //  {
            //      Console.WriteLine("Os números são iguais!");
            //  } else
            //  {
            //      Console.WriteLine(numero2);
            //  }

            // 16.Entrar com dois números e imprimir o menor numero(suponha números diferentes).

            //  Console.WriteLine("Insira o primeiro número!");
            //  var numero1 = Convert.ToInt64(Console.ReadLine());
            //
            //  Console.WriteLine("Insira o segundo número!");
            //  var numero2 = Convert.ToInt64(Console.ReadLine());
            //
            //  if (numero1 > numero2)
            //  {
            //      Console.WriteLine(numero2);
            //  }
            //  else if (numero1 == numero2)
            //  {
            //      Console.WriteLine("Os números são iguais!");
            //  }
            //  else
            //  {
            //      Console.WriteLine(numero1);
            //  }




            //17.Entrar com dois números e imprimi - los em ordem crescente(suponha números diferentes).

            //  Console.WriteLine("Insira o primeiro número!");
            //  var numero1 = Convert.ToInt64(Console.ReadLine());
            //
            //  Console.WriteLine("Insira o segundo número!");
            //  var numero2 = Convert.ToInt64(Console.ReadLine());
            //
            //  if (numero1 < numero2)
            //  {
            //      Console.WriteLine(numero1 + "  " + numero2 );
            //  }
            //  else
            //  {
            //      Console.WriteLine(numero2 + "  " + numero1);
            //  }


            // 18.Entrar com dois números e imprimi - los em ordem decrescente(suponha números diferentes).

          //  Console.WriteLine("Insira o primeiro número!");
          //  var numero1 = Convert.ToInt64(Console.ReadLine());
          //
          //  Console.WriteLine("Insira o segundo número!");
          //  var numero2 = Convert.ToInt64(Console.ReadLine());
          //
          //  if (numero1 > numero2)
          //  {
          //      Console.WriteLine(numero1 + "  " + numero2);
          //  }
          //  else
          //  {
          //      Console.WriteLine(numero2 + "  " + numero1);
          //  }




        }
    } 
}