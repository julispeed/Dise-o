using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Xml.Serialization;
=======
>>>>>>> 9d3cbedb62d0d9902d0b876efdc4fb3c188d9b4a

namespace ProyectoFecha
{

    public class Fecha 
    {
<<<<<<< HEAD

        #region Atributos estaticos
        //DECLARACION DE ATRIBUTOS ESTATICOS
=======
        #region Atributos estaticos
>>>>>>> 9d3cbedb62d0d9902d0b876efdc4fb3c188d9b4a
        private static int dia_inicial = 1;
        private static int mes_inicial = 1;
        private static int ano_inicial = 2000;
        #endregion

        #region Atributos
        //Declaracion de Atributos
        private int _dia;
        private int _mes;
        private int _ano;
        #endregion
        #region Propiedades
        public int D
        {
            get { return _dia; }
            set {
                this._dia = EsFechaValida(value, mes_inicial, ano_inicial) ? value : _dia;
            }
        }        
        public int M
        {
            get { return _mes; }
            set {
                this._mes = EsFechaValida(dia_inicial, value, ano_inicial) ? value : _mes;
                }
        }
        public int A
        {
            get { return _ano; }
            set
            {
                this._ano=EsFechaValida(dia_inicial, mes_inicial, value) ? value : _ano;
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
<<<<<<< HEAD
        public void IncrementarDia()
        {
            if (D == UltimoDiaDelMes(M,A))
            {
                D = 1;
                if(M==12)
                {
                    A++;
                    M = 1;
                }
                else
                {
                    M++;
                }
            }
            else
            {
                D++;
            }
        }
        public void DecrementarDia()
        {
            //if (D == UltimoDiaDelMes(M, A))
            //{
            //    D = 1;
            //    if (M == 12)
            //    {
            //        A++;
            //        M = 1;
            //    }
            //    else
            //    {
            //        M++;
            //    }
            //}
            //else
            //{
            //    D++;
            //}
        }
        public static int UltimoDiaDelMes(int mes, int ano)
        {
            int ultimodia = 0;
            if (mes==1 || mes==3 || mes == 5 || mes==7 || mes == 8 || mes == 10 || mes ==12)
            {
                ultimodia = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes ==11)
            {
                ultimodia = 30;
            }
            else if (mes==2 && Esbisiesto(ano))
            {
                ultimodia = 29;
            }
            else if (mes==2 && !Esbisiesto(ano))
            {
                ultimodia = 28;
            }
            return  ultimodia;
        }
=======

>>>>>>> 9d3cbedb62d0d9902d0b876efdc4fb3c188d9b4a
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
<<<<<<< HEAD
            if ((a % 4 == 0 && a % 100 != 0) || (a % 400 == 0))
=======
            if (a % 4 == 0 || a==0)
>>>>>>> 9d3cbedb62d0d9902d0b876efdc4fb3c188d9b4a
                resultado = true;

           return resultado;
        }
<<<<<<< HEAD

        public bool EsIgualA(Fecha OtraFecha)
        {
            return ((OtraFecha.D == this.D) && (OtraFecha.M == this.M) && (OtraFecha.A == this.A));                        
        }

        public bool MayorQue(Fecha OtraFecha)
        {
            bool respuesta = false;
            if (OtraFecha.A>this.A)
            {
                respuesta = true;
            }    
            else if (OtraFecha.A==this.A && OtraFecha.M>this.M)
            {
                respuesta = true;
            }
            else if (OtraFecha.A == this.A && OtraFecha.M==this.M && OtraFecha.D>this.D)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public bool MenorQue(Fecha OtraFecha)
        {
            bool respuesta = false;
            if (OtraFecha.A < this.A)
            {
                respuesta = true;
            }
            else if (OtraFecha.A == this.A && OtraFecha.M < this.M)
            {
                respuesta = true;
            }
            else if (OtraFecha.A == this.A && OtraFecha.M == this.M && OtraFecha.D < this.D)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public int DiferenciaEntreFechas(Fecha OtraFecha)
        {
            int cantDias = 0;           
          if (this.MayorQue(OtraFecha))
            {
                
                Fecha Aux = new Fecha(this.D, this.M, this.A);
                while (!Aux.EsIgualA(OtraFecha))
                {
                    Aux.IncrementarDia();
                    cantDias++;
                }
            }
          else
            {
                while (!OtraFecha.EsIgualA(this))
                {
                    OtraFecha.IncrementarDia();
                    cantDias++;
                }
            }
          
            return cantDias;
        }
        
=======
>>>>>>> 9d3cbedb62d0d9902d0b876efdc4fb3c188d9b4a
        #endregion
    }
}
