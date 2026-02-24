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
            cuentabancaria cuentabancaria = new cuentabancaria();
            cuentaahorros cuentaa = new cuentaahorros();
            cuentacorriente cuentacorriente = new cuentacorriente();
            cuentanomina cuentanomina = new cuentanomina();
            cuentabancaria.datos();
            cuentabancaria.depositar();
            cuentaa.calcularinteres();
            cuentacorriente.retirar();
            cuentanomina.calcularinteres();
        }
    }
    public class cuentabancaria
    {
        public int ncuenta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }
       

        public void datos()
        {
            Console.WriteLine("escribe el numero de tu cuenta");
            ncuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe el titular de tu cuenta");
            titular = Console.ReadLine();
            Console.WriteLine($"tu saldo es {saldo}");
        }
        public void depositar()
        {
            Console.WriteLine("cuanto deseas depositar?");
            double deposito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"tu nuevo saldo es {saldo}");
        }

    }
    public class cuentaahorros : cuentabancaria
    {
        public double tasadinteres { get; set; }
        
        public void calcularinteres()
        {
            Console.WriteLine("cuanto es la tasa de interes? (en decimal)");
            tasadinteres = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"el interes generado es: {tasadinteres*saldo}" );
          
        }

    }
    public class cuentacorriente : cuentabancaria
    {
        public double r { get; set; }
        public double limitesobreigiro { get; set; }
        public void retirar ()
        {
            Console.WriteLine($"cuanto deseas retirar? tu saldo es {saldo}");
             r = Convert.ToDouble(Console.ReadLine());
            saldo = saldo - r;
            limitesobreigiro = 45000;
            if (saldo > limitesobreigiro)
            {
                saldo = saldo - 20;
            }
        }

    }
    public class cuentanomina : cuentabancaria
    {
        public string empresa { get; set; }
        public void calcularinteres()
        {
            Console.WriteLine("escribe el nombre de tu empresa");
            empresa = Console.ReadLine();
            Console.WriteLine($"el interes mensual es de {saldo * 0.01}");
        }
    }
}
