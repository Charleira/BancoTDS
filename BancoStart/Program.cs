namespace Banco
{
    using System.Security.Cryptography;
    using System.Threading;
    class BancoStart
    {
        public bool start = false;
        public float saque;
        static void Main()
        {

            int q200 = 100, q100 = 300, q50 = 500, q25 = 600, q10 = 700, q05 = 800, q02 = 1000, Cedulas = 0, Saldo = 600; //variaveis  
            Console.WriteLine("cedulas disponiveis\n");
            Console.WriteLine(" R$ 200,00\t" + q200);
            Console.WriteLine("\n R$ 100,00\t" + q100);
            Console.WriteLine("\n R$ 50,00\t" + q50);
            Console.WriteLine("\n R$ 25,00\t" + q25);
            Console.WriteLine("\n R$ 10,00\t" + q10);
            Console.WriteLine("\n R$ 5,00\t" + q05);
            Console.WriteLine("\n R$ 2,00\t" + q02);
            Console.WriteLine("\n\nDeseja realizar um SAQUE? (y/n)"); //receber se deseja sacar
            string startQ = Console.ReadLine();
            Console.Clear();
            if (startQ == "y")
            {
                //Boolean start = true;
                Console.WriteLine("Selecione o valor que deseja sacar: "); // valor de saque
                int Saque = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Saque < Saldo)
                {
                    Console.WriteLine("O saque será de: R$ " + Saque);
              
                    while (Saque > 0)
                    {
                        switch (Saque)                                         // faz a verificação do saldo com o valor a ser sacado
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
                    Console.Clear();
                    Console.WriteLine($" A quantidade de Cedulas sacadas para o valor R$ {Saque} foi de: {Cedulas}"); //respsota caso haja o saque
                }
                else
                {
                    Console.WriteLine($"Saldo indisponivel o seu saldo é de {Saldo}"); //resposta com saldo 
                }
            }

            else
            {
                Console.WriteLine("Informacao invalida"); // resposta para pergunta se quer realizar
            }
         
        }
    }
}