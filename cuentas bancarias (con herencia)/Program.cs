using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_bancarias__con_herencia_
{
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
    public class cuentabancaria
    {
        public int ncuenta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public void datos()
        {
            Console.WriteLine($"numero de cuenta: {ncuenta}");
            Console.WriteLine($"titular de la cuenta>: {titular}");
            Console.WriteLine($"tu saldo es {saldo}");
        }
        public void depositar()
        {
            Console.WriteLine("cuanto deseas depositar?");
            double deposito = Convert.ToDouble(Console.ReadLine());
            saldo = saldo + deposito;
            Console.WriteLine($"tu nuevo saldo es {saldo}");
        }

    }
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
            Console.WriteLine($"el interes generado es: {tasadinteres*saldo}" );
          
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
    public class cuentacorriente : cuentabancaria
    {
        public cuentacorriente()
        {
            saldo = 0;
            ncuenta=9321754;
            titular= "Mariana";
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
