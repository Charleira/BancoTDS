namespace Banco
{ 
    using System.Threading;
    class BancoStart
    {

        static int InicioM()
        {
            Console.WriteLine("\t\t\t\t\t*******\tBEM VINDO AO BANCO TRANSDATA\t*******");
            Console.WriteLine("\n\n\n\t\t\t\t\t1 - Realizar Saque\n\n\n\t\t\t\t\t2 - Verificar Saldo\n\n\n\t\t\t\t\t0 - Sair");

            int Inicio;

            if (int.TryParse(Console.ReadLine(), out Inicio))
            {
                if (Inicio == 1 || Inicio == 2 || Inicio == 0)
                {
                    if (Inicio == 1)
                    {
                        Console.WriteLine("realizar saque");
                        Thread.Sleep(150);
                    }
                    else if (Inicio == 2)
                    {
                        Console.WriteLine("verificar Saldo");
                        Thread.Sleep(150);
                        return Inicio;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("código invalido inserido!\n\nAperte qualquer tecla para voltar");
                    Console.ReadKey();
                    Console.Clear();
                    return InicioM();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada invalida!!Por favor insira um valor numérico\n\nAperte qualquer tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                return InicioM();
            }

            return Inicio;
        }

        static void Main()
        {
            int q200 = 100, q100 = 300, q50 = 500, q25 = 600, q10 = 700, q05 = 800, q02 = 1000, Cedulas = 0, Saldo1 = 600, Saldo2; //variaveis  
            int escolha = InicioM();
            if (escolha == 2)
            {
                Console.Clear();
                Console.WriteLine($"O seu saldo e de R$ {Saldo1}");
                Console.WriteLine("\nPressione qualquer tecla para ir para o saque");
                Console.ReadKey();
                Console.Clear();
            }

            else if (escolha == 0)
            {
                Console.WriteLine("Saindo do sistema...");
                Environment.Exit(0);
            }

            //para baixo esta certo, mas o menu nao funciona
            Console.WriteLine("cedulas disponiveis\n");
            Console.WriteLine(" R$ 200,00\t" + q200);
            Console.WriteLine("\n R$ 100,00\t" + q100);
            Console.WriteLine("\n R$ 50,00\t" + q50);
            Console.WriteLine("\n R$ 25,00\t" + q25);
            Console.WriteLine("\n R$ 10,00\t" + q10);
            Console.WriteLine("\n R$ 5,00\t" + q05);
            Console.WriteLine("\n R$ 2,00\t" + q02);
            Console.WriteLine("\n\n Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            //Boolean start = true;
            Console.WriteLine("Selecione o valor que deseja sacar: ");
            int SaqueI;// valor de saque
            if (int.TryParse(Console.ReadLine(), out SaqueI))
            {
                Console.Clear();
                int Saque = SaqueI;

                if (Saque < Saldo1)  // faz a verificação do saldo com o valor a ser sacado
                { 
                    if (Saque %2 == 0)
                    {
                        Console.WriteLine("O saque será de: R$ " + Saque);
                        while (Saque != 0)
                        {
                            switch (Saque)
                            {
                                case >= 200:
                                    q200--;
                                    Console.WriteLine("\nCedula de R$ 200 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 200;
                                    Cedulas++;
                                    break;


                                case >= 100:
                                    q100--;
                                    Console.WriteLine("\nCedula de R$ 100 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 100;
                                    Cedulas++;
                                    break;
                                case >= 50:
                                    q50--;
                                    Console.WriteLine("\nCedula de R$ 50 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 50;
                                    Cedulas++;
                                    break;
                                case >= 10:
                                    q10--;
                                    Console.WriteLine("\nCedula de R$ 10 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 10;
                                    Cedulas++;
                                    break;
                                case >= 02:
                                    q02--;
                                    Console.WriteLine("\nCedula de R$ 2 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 2;
                                    Cedulas++;
                                    break;
                            }


                        }

                    }
                    else
                    {
                        while (Saque != 0)
                        {
                            switch (Saque)
                            {
                                case >= 200:
                                    q200--;
                                    Console.WriteLine("\nCedula de R$ 200 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 200;
                                    Cedulas++;
                                    break;
                                case >= 100:
                                    q100--;
                                    Console.WriteLine("\nCedula de R$ 100 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 100;
                                    Cedulas++;
                                    break;
                                case >= 50:
                                    q50--;
                                    Console.WriteLine("\nCedula de R$ 50 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 50;
                                    Cedulas++;
                                    break;
                                case >= 25:
                                    q25--;
                                    Console.WriteLine("\nCedula de R$ 25 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 25;
                                    Cedulas++;
                                    break;
                                case >= 10:
                                    q10--;
                                    Console.WriteLine("\nCedula de R$ 10 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 10;
                                    Cedulas++;
                                    break;
                                case >= 05:
                                    q05--;
                                    Console.WriteLine("\nCedula de R$ 5 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 5;
                                    Cedulas++;
                                    break;
                                case >= 02:
                                    q02--;
                                    Console.WriteLine("\nCedula de R$ 2 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 2;
                                    Cedulas++;
                                    break;
                            }
                        }
                            }
                    Console.Clear();
                    Saldo2 = Saldo1 - SaqueI;
                    Console.WriteLine($" A quantidade de Cedulas sacadas para o valor R$ {SaqueI} foi de: {Cedulas} cedulas\n\t E agora seu saldo ficou em {Saldo2}!"); //resposta caso haja o saque
                }


                else
                {
                    Console.WriteLine($"Saldo indisponivel seu saldo e de {Saldo1}"); // resposta para pergunta se quer realizar
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Informação invalida por favor insira um valor que deseja sacar Ex: 500");
            }
        }
    }
}