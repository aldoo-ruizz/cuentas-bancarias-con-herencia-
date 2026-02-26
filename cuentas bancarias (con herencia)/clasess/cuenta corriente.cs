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
    public class cuentacorriente : cuentabancaria
    {
        public cuentacorriente()
        {
            saldo = 0;
            ncuenta = 9321754;
            titular = "Mariana";
        }
        public double limitesobregiro { get; set; }
        public double calcularinteres()
        {
            return 0;
        }

        public void retirar()
        {
            limitesobregiro = 1000;

            Console.WriteLine("¿Cuánto deseas retirar?");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (saldo - retiro >= -limitesobregiro)
            {
                saldo -= retiro;

                if (saldo < 0)
                {
                    saldo -= 20;
                    Console.WriteLine("Se aplicó comisión de 20 por sobregiro");
                }

                Console.WriteLine("Retiro realizado. Saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("Excede el límite de sobregiro");
            }
        }
    }
}
