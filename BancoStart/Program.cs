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

            if (int.TryParse(Console.ReadLine(), out Inicio)) // tenta converter o que foi inserido em um valor numérico
            {
                if (Inicio == 1 || Inicio == 2 || Inicio == 0) // valida se o valor inserido é um das 3 opções 
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
                else //caso o numero inserido nao seja as opções
                {
                    Console.Clear();
                    Console.WriteLine("código invalido inserido!\n\nAperte qualquer tecla para voltar");
                    Console.ReadKey();
                    Console.Clear();
                    return InicioM();
                }
            }
            else // caso o que foi inserido nao for um numero
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
            int q200 = 100, q100 = 300, q50 = 500, q20 = 600, q10 = 700, q05 = 800, q02 = 1000, Cedulas = 0, Saldo1 = 600, Saldo2; //variaveis  
            int escolha = InicioM();// receber o que foi retornado no metodo anterior em uma variavel
            if (escolha == 2) //o que fazer ao escolher as opções do menu
            {
                Console.Clear();
                Console.WriteLine($"O seu saldo e de R$ {Saldo1}");
                Console.WriteLine("\nPressione qualquer tecla para ir para o saque");
                Console.ReadKey();
                Console.Clear();
            }

            else if (escolha == 0)//o que fazer ao escolher as opções do menu
            {
                Console.WriteLine("Saindo do sistema...");
                Environment.Exit(0);
            }

            Console.WriteLine("cedulas disponiveis\n");
            Console.WriteLine(" R$ 200,00\t" + q200);
            Console.WriteLine("\n R$ 100,00\t" + q100);
            Console.WriteLine("\n R$ 50,00\t" + q50);
            Console.WriteLine("\n R$ 20,00\t" + q20);
            Console.WriteLine("\n R$ 10,00\t" + q10);
            Console.WriteLine("\n R$ 5,00\t" + q05);
            Console.WriteLine("\n R$ 2,00\t" + q02);
            Console.WriteLine("\n\n Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            //opções de cedulas disponiveis na maquina
            Console.WriteLine("Selecione o valor que deseja sacar: "); //receber quanto quer sacar
            int SaqueI;// valor de saque
            if (int.TryParse(Console.ReadLine(), out SaqueI))
            {
                Console.Clear();
                int Saque = SaqueI;

                if (Saque < Saldo1)  // faz a verificação do saldo com o valor a ser sacado
                { 
                    if (Saque %2 == 0)//verifica se o saque é divisivel por 2 e faz a leitura do resto
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
                                case >= 20:
                                    q20--;
                                    Console.WriteLine("\nCedula de R$ 20 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 20;
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
                    else // se nao for divisivel por 2 vem para esse segundo looping
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
                                case >= 20:
                                    q20--;
                                    Console.WriteLine("\nCedula de R$ 20 sacada");
                                    Thread.Sleep(1500);
                                    Saque -= 20;
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
                    Saldo2 = Saldo1 - SaqueI;//saber quanto foi o saldo que restou para o cliente
                    Console.WriteLine($" A quantidade de Cedulas sacadas para o valor R$ {SaqueI} foi de: {Cedulas} cedulas\n\n E agora seu saldo ficou em {Saldo2}!"); //resposta caso haja o saque
                }


                else
                {
                    Console.WriteLine($"Saldo indisponivel seu saldo e de {Saldo1}"); // resposta caso o saldo for menor que a quantia desejada no saque
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Informação invalida por favor insira um valor que deseja sacar Ex: 500");//resposta caso o valor inserido for diferente de inteiro
            }
        }
    }
}