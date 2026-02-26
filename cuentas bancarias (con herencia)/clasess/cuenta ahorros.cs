using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_bancarias__con_herencia_.clasess
{
    public class cuentaahorros : cuentabancaria
    {
        public cuentaahorros()
        {
            saldo = 0;
            ncuenta = 1234567;
            titular = "Aldo";
        }
        public double tasadinteres { get; set; }

        public void calcularinteresa()
        {
            Console.WriteLine("cuanto es la tasa de interes? (ejemplo 0.05)");
            tasadinteres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"el interes generado es: {tasadinteres * saldo}");

        }
        public void retirar()
        {
            Console.WriteLine("¿Cuánto deseas retirar?");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (saldo - retiro < 500)
            {
                Console.WriteLine("No se puede retirar. Saldo mínimo 500");
            }
            else
            {
                saldo -= retiro;
                Console.WriteLine("Retiro realizado. Saldo: " + saldo);
            }
        }

    }
}
