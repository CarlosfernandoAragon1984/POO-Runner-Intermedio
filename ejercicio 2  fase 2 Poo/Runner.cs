using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_2__fase_2_Poo
{
    class Runner
    {
        private const double kmSesMax = 50, kmSesMin = 1, KmObjMax = 500, KmObjeMin = 1;
        private double kmObjetivo = 0,objetivoKmSes=0;
        private double kmSes = 0;
        private const  int maxSesiones = 500;
        private double[] sesiones = new double[maxSesiones];


        public Runner()
        {
            int ses = 0;
            ObjetivoKmXSes = 0;

            this.sesionesDisponibles = maxSesiones;
            do 
            {
                sesiones[ses] = 0;
                ses++;
                
            } while (ses<maxSesiones);
        }
      
        
        public int sesionesDisponibles { get; private set; }
       
        
        public double ObjetivoKmXSes 
        {
            set
            {
                if(value>=kmSesMin && value <= kmSesMax)
                {
                    objetivoKmSes = value;
                }

            }
            get
            {
                return objetivoKmSes;
            }
        }
        public double kmTotalR { get; private set; }



        public double ObjetivoKm
        {

            set
            {
                if (value <= KmObjMax && value >= kmSesMin)
                {
                    kmObjetivo = value;
                }
            }
            get
            {
                return kmObjetivo;
            }

        }
        public string GuardarSesion(double SesKM)

        {
            kmSes = SesKM;
            
            if (sesionesDisponibles==0)
            {
                return "No hay sesiones disponibles";

            }
            if (kmSes<kmSesMin || kmSes > kmSesMax)
            {
                return "Debe ingresar un valor entre 1 y 50";
            }
            sesiones[maxSesiones - sesionesDisponibles] = kmSes;
            sesionesDisponibles -= 1;
            kmTotalR = kmTotalR + kmSes;
            return "";



        }
        public string Estadistica()
        {
            string detalle = "";
            int ses = 0;
            do
            {
                detalle = detalle + "\n\t\t" + sesiones[ses];
               
                if (sesiones[ses] >= ObjetivoKmXSes)
                {
                    detalle = detalle + "\tS";
                }
                if (sesiones[ses] < ObjetivoKmXSes)
                {
                    detalle = detalle + "\tN";
                }
                ses++;

            } while (ses<maxSesiones-sesionesDisponibles);
            if (detalle == "")
            {
                detalle = "\n\tNo hay sesiones ingresadas";
            }
            else
            {
                detalle = "\n\tDetalle de las Sesiones:\n\t\tKms\tObj Kms" + detalle;
            }

             string cabecera = "";
            cabecera = "Estadistica\n\t Objetivos en kms:" + ObjetivoKm + "\tRealizados" + kmTotalR 
                + "\nel objetivo de kms por sesión: " + ObjetivoKmXSes; ;
            if (kmTotalR != 0 && kmTotalR > ObjetivoKm)
            {
                cabecera = cabecera + "\tObjetivo Cumplido";
            }
            return cabecera + detalle;
        }
    }
}
