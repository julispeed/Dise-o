using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFecha
{

    public class Fecha 
    {
        #region Atributos estaticos
        private static int dia_inicial = 1;
        private static int mes_inicial = 1;
        private static int ano_inicial = 2000;
        #endregion

        #region Atributos
        //Declaracion de Atributos
        private int _dia=1;
        private int _mes=1;
        private int _ano=2000;
        #endregion
        #region Propiedades
        public int D
        {
            get { return _dia; }
            set {
                this._dia = EsFechaValida(value, _mes, _ano) ? value : _dia;
            }
        }        
        public int M
        {
            get { return _mes; }
            set {
                this._mes = EsFechaValida(_dia, value, _ano) ? value : _mes;
                }
        }
        public int A
        {
            get { return _ano; }
            set
            {
                this._ano=EsFechaValida(_dia, _mes, value) ? value : _ano;
            }
        }
        #endregion
        #region Constructor
        public Fecha (int d,int m , int a)
        {
            if ( EsFechaValida(d,m,a))
            {
                D = d;
                M = m;
                A = a;
            }
            else
            {
                D = dia_inicial;
                M = mes_inicial;
                A = ano_inicial;
            }
        }
        public Fecha()
        {
            D= dia_inicial;
            M= mes_inicial;
            A= ano_inicial;
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
                        if (d<1 | d>31)
                    {
                        resultado = false;
                    }
                        break;
                    case 3:// Marzo
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 5:  // Mayo
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 7:  // Julio
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 8:  // Agosto
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 10: // Octubre
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 12: // Diciembre
                        if (d <=0 || d > 31)
                        { resultado = false; }
                        break;
                    case 4:  // Abril
                        if (d <=0 & d >= 31)
                        { resultado = false; }
                        break;
                    case 6:  // Junio
                        if (d <=0 & d >= 31)
                        { resultado = false; }
                        break;
                    case 9:  // Septiembre
                        if (d <=0 & d >= 31)
                        { resultado = false; }
                        break;
                    case 11: // Noviembre
                        if (d <=0 & d >= 31)
                        { resultado = false; }
                        break;
                    case 2:  // Febrero
                        if (Esbisiesto(a))
                        {
                            if (d <=0 || d > 28)
                                resultado = false;

                        }
                        else
                        {
                            if (d <=0 || d > 29)
                                resultado = false;
                        }
                        break;
                    default:
                    if (m < 1 || m > 12)
                        resultado = false;
                    break;
                }                   
            return resultado;            
        }

        public static bool Esbisiesto(int a)
        {
            bool resultado = false;
            if (a % 4 == 0 || a==0)
                resultado = true;

           return resultado;
        }
        #endregion
    }
}
