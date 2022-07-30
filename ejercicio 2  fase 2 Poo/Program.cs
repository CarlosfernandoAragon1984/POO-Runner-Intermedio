using System;

namespace ejercicio_2__fase_2_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner miRunner = new Runner();
            AppRunner miAppRunner = new AppRunner();
            miAppRunner.MenuPrincipal(miRunner);
        }
    }
}
