using System;


namespace Calculadora
{
    class Program
    {
        enum Menu{Soma = 1 ,Subtracao = 2,Divisao = 3 ,Multiplicacao = 4,Potencia = 5 ,Raiz = 6, Sair=7}

        static void Main(string[]args )
        {

            bool escolheuSair = false;
            while(!escolheuSair)//Equanto o usuario NÃO(!) escolher sair, exiba o Menu
            {
            Console.WriteLine("Seja bem vindo ao Calc, selecione uma das opções:");
            Console.WriteLine("1-Soma\n2-Subração\n3-Divisão\n4-Multiplicação\n5-Potenciação\n6-Raiz\n7-Sair");


            Menu opcao =(Menu)int.Parse(Console.ReadLine());
            
      
          switch (opcao)
          {
            case Menu.Soma:
                  Soma();
                  break;
            case Menu.Subtracao:
                 Subtracao();
                 break;
            case Menu.Divisao:
                 Divisao();
                 break;
            case Menu.Multiplicacao:
                 Multiplicacao();
                 break;
            case Menu.Potencia:
                 Potencia();
                 break;
            case Menu.Raiz:
                 RaizQ();
                 break;
            case  Menu.Sair:
                  escolheuSair = true;
                  break;
}
             Console.Clear();

            }
          
        }


        static void Soma()
        {
            Console.Write("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
             int b = int.Parse(Console.ReadLine());
             int resultado = a+b;
             Console.WriteLine($"O resultado da soma é: {resultado}");
             Console.WriteLine("Aperte ENTER para voltar para o menu");
             Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.Write("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a-b;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Divisao()
        {
            Console.Write("Divisão entre dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Multiplicacao()
        {
            Console.Write("Multiplicação entre dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a*b;
            Console.WriteLine($"O resultado da multiplicação  é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Potencia()
        {
            Console.Write("Potência de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum,expo);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void RaizQ()
        {
            Console.Write("Raiz  quadradade um número: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = (int)Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        

    }
}