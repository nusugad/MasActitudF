using System;
using System.Collections.Generic;
using System.Text;

namespace MasActitud.Utilidades
{
    public interface ICalculos
    {
        int calculoEdad(DateTime fechaNacimiento);
    }
    public class Calculos : ICalculos
    {
        public int calculoEdad(DateTime fechaNacimiento) 
        {
            int anoNacimiento = fechaNacimiento.Year;
            int mesNacimiento = fechaNacimiento.Month;
            int diaNacimiento = fechaNacimiento.Day;
            int anoActual = DateTime.Now.Year;
            int mesActual = DateTime.Now.Month;
            int diaActual = DateTime.Now.Day;
            int Edad;


            if (mesNacimiento > mesActual || (mesNacimiento == mesActual && diaActual < diaNacimiento))
            {
                Edad = ((anoActual - anoNacimiento) - 1);
            }
            else
            {
                Edad = (anoActual - anoNacimiento);
            }

            return Edad;
        }
    }
}
