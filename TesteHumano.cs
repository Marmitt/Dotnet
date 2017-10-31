using System;

namespace console_dotnet
{
    class TesteHumano
    {
        public void numerogerado(int a, int b) {
            Random t = new Random();
            int c = t.Next(a, b);
            int d = t.Next(a, b);
            int soma = c + d;
            System.Console.WriteLine(c + "+" + d);

            int resp = Convert.ToInt32(Console.ReadLine());

            if (resp == soma) {
                System.Console.WriteLine("Acesso Liberado");
            }
            else {
                System.Console.WriteLine("Acesso Negado");  
            }
        }    
    
    }
}