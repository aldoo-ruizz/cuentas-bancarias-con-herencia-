using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_bancarias__con_herencia_.clasess
{
    /// <summary>
    /// ARD 20260226
    /// Se crearon 4 clases: cuentabancaria, cuentaahorros, cuentacorriente y cuentanomina. 
    /// </summary>
    public class cuentanomina : cuentabancaria
    {
        public cuentanomina()
        {
            saldo = 0;
            ncuenta = 3803724;
            titular = "Carlos";
        }
        public string empresa { get; set; }
        public void calcularinteresn()
        {
            Console.WriteLine("escribe el nombre de tu empresa");
            empresa = Console.ReadLine();
            Console.WriteLine($"saldo depositado en {empresa} el interes mensual es de {saldo * 0.01}");
        }
        public void retirar()
        {
            Console.WriteLine("¿Cuánto deseas retirar?");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (retiro <= saldo)
            {
                saldo -= retiro;
                Console.WriteLine("Retiro realizado. Saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("Fondos insuficientes");
            }
        }
    }
}
