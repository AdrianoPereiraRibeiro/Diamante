namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor ímpar para gerar o diamante:"); 
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("O número não é ímpar. Por favor, insira um número ímpar.");
            }
            else
            {
                int espacos = n / 2;
                int xxx = 1;

               
                for (int i = 0; i < (n / 2) + 1; i++)
                {
                    Console.Write(new string(' ', espacos));
                    Console.WriteLine(new string('X', xxx));
                    espacos--;
                    xxx += 2;
                }

                espacos = 1;
                xxx = n - 2;

                
                for (int i = (n / 2); i > 0; i--)
                {
                    Console.Write(new string(' ', espacos));
                    Console.WriteLine(new string('X', xxx));
                    espacos++;
                    xxx -= 2;
                }
            }

            Console.ReadLine();
        }
    }
}
