using System;

namespace console_dotnet
{
    class TesteHumano
    {
        public void numerogerado(int a, int b) {
            Random t = new Random();
            int c = t.Next(a, b);
            int d = t.Next(a, b);
            System.Console.WriteLine(c + d);

        }    
    
    }
}