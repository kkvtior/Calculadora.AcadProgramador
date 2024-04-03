Using System;

Class Program
{
    Static void Main()
    {
        While (True)
        {
            Console.WriteLine("Escolha a opera��o:");
            Console.WriteLine("1 - Adi��o");
            Console.WriteLine("2 - Subtra��o");
            Console.WriteLine("3 - Multiplica��o");
            Console.WriteLine("4 - Divis�o");
            Console.WriteLine("0 - Sair");

            int opcao;
            If (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Op��o inv�lida. Por favor, tente novamente.");
                Continue Do;
            }

            If (opcao == 0)
            {
                break;
            }

            Double numero1, numero2;
            Console.Write("Digite o primeiro n�mero: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo n�mero: ");
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
                        Console.WriteLine("N�o � poss�vel dividir por zero.");
                        Continue Do;
                    }
                    break;
                Default: 
                    Console.WriteLine("Op��o inv�lida. Por favor, tente novamente.");
                    Continue Do;
            }

            Console.WriteLine("O resultado �: " + resultado.ToString("F2"));
        }
    }
}