using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFecha
{
    internal class Fecha
    {
        #region Atrobitos estaticos
        private static int dia_inicial = 1;
        private static int mes_inicial = 1;
        private static int ano_inicial = 2000;
        #endregion

        #region Atributos
        //Declaracion de Atributos
        private int dia;
        private int mes;
        private int ano;
        #endregion
        #region Propiedades
        public int D
        {
            get { return dia; }
            set { if (EsFechaValida(value, mes, ano))
                    dia = value;
                    }
        }
        public int M
        {
            get { return mes; }
            set { if (EsFechaValida(dia, value, ano))
                    mes = value;
                    }
        }
        public int A
        {
            get { return ano; }
            set { if (EsFechaValida(dia, mes, value))
                    ano = value;
            }
        }
        #endregion
        #region
        public Fecha (int d,int m , int a)
        {
            if ( EsFechaValida(d,m,a))
            {
                dia = d;
                mes = m;
                ano = a;
            }
            else
            {
                dia = dia_inicial;
                mes = mes_inicial;
                ano = ano_inicial;
            }
        }
        #endregion
        #region Comandos

        #endregion

        #region Consultas

        public static bool EsFechaValida(int d,int m, int a)
        {
            bool resultado = true;


            switch (m)
            {
                case 1://enero
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 3:// Marzo
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 5:  // Mayo
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 7:  // Julio
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 8:  // Agosto
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 10: // Octubre
                    if (d < 0 || d > 31)
                    { resultado = false; }
                    break;
                case 12: // Diciembre
                    if (d < 0 || d >31)
                    { resultado = false; }
                    break;                                        
                case 4:  // Abril
                    if (d < 0 & d >=31)
                    { resultado = false; }
                    break;
                case 6:  // Junio
                    if (d < 0 & d >= 31)
                    { resultado = false; }
                    break;
                case 9:  // Septiembre
                    if (d < 0 & d >= 31)
                    { resultado = false; }
                    break;
                case 11: // Noviembre
                    if (d < 0 & d >= 31)
                    { resultado = false; }                    
                    break;
                case 2:  // Febrero
                    if (Esbisiesto(a))
                    {
                        if (d<0 || d>28)                        
                            resultado = false;
                        
                    }
                    else
                    {
                        if (d < 0 || d > 29)
                            resultado = false;
                    }
                    break;
                default:
                    resultado=false;
                    break;

            }
            return resultado;
            
        }

        public static bool Esbisiesto(int a)
        {
            bool resultado = false;
            if (a % 4 == 0)
                resultado = true;

           return resultado;
        }
        #endregion
    }
}
