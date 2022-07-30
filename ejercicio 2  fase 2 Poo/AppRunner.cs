using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2__fase_2_Poo
{
    class AppRunner
    {
        private const string fijarObjetivo = "O", agregarSesion = "A", estadisticas = "E", salir = "S";
        private string Opcion = "";



        public void MenuPrincipal(Runner unRunner)
        {
            do
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine(fijarObjetivo + "-Fijar Objetivo");
                Console.WriteLine(agregarSesion + "-Agregar Sesión");
                Console.WriteLine(estadisticas + "-Ver Estadística");
                Console.WriteLine(salir + "-Salir");
                Opcion = ConvalDatos.PedirStrNoVac("Eliga una Opción");
                switch (Opcion)
                {
                    case fijarObjetivo:
                        FijarObjetivo(unRunner);
                        break;
                    case agregarSesion:
                        AgregarSesion(unRunner);
                        break;
                    case estadisticas:
                        Console.WriteLine(unRunner.Estadistica());
                        break;
                    case salir:
                        break;
                    default:
                        break;
                }
            } while (Opcion != salir);

        }
        public void FijarObjetivo(Runner unRunner)
        {
            unRunner.ObjetivoKm = ConvalDatos.PedirDouble("Ingrese el objetivo en km", 1, 500);
            unRunner.ObjetivoKmXSes = ConvalDatos.PedirDouble("Ingrese el objetivo por sesión", 1, 50);
        }
        public void AgregarSesion(Runner unRunner)
        {
            double Kilometros = 0;

            Kilometros = ConvalDatos.PedirDouble("Ingrese los km recorridos", 1, 50);
            unRunner.GuardarSesion(Kilometros);


        }
    }
}
