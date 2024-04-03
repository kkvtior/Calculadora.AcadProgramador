Using System;

Class Program
{
    Static void Main()
    {
        While (True)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            int opcao;
            If (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                Continue Do;
            }

            If (opcao == 0)
            {
                break;
            }

            Double numero1, numero2;
            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            Double resultado = 0;

            switch (opcao)
            {
                Case 1 : 
                    resultado = numero1 + numero2;
                    break;
                Case 2 : 
                    resultado = numero1 - numero2;
                    break;
                Case 3 : 
                    resultado = numero1 * numero2;
                    break;
                Case 4
    If (numero2!= 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    Else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        Continue Do;
                    }
                    break;
                Default: 
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                    Continue Do;
            }

            Console.WriteLine("O resultado é: " + resultado.ToString("F2"));
        }
    }
}