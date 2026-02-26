using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using cuentas_bancarias__con_herencia_.clasess;

namespace cuentas_bancarias__con_herencia_
{
    /// <summary>
    /// ARD 20260226
    /// Se crearon 4 clases: cuentabancaria, cuentaahorros, cuentacorriente y cuentanomina. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            cuentaahorros cuentaa = new cuentaahorros();
            cuentacorriente cuentacorriente = new cuentacorriente();
            cuentanomina cuentanomina = new cuentanomina();
            Console.WriteLine("----cuenta ahorros----");
            cuentaa.datos();
            cuentaa.depositar();
            cuentaa.calcularinteresa();
            Console.WriteLine("----cuenta corriente----");
            cuentacorriente.datos();
            cuentacorriente.depositar();
            cuentacorriente.retirar();
            Console.WriteLine("----cuenta nomina----");
            cuentanomina.datos();
            cuentanomina.depositar();
            cuentanomina.calcularinteresn();
        }
    }
    
    
    
    
}
