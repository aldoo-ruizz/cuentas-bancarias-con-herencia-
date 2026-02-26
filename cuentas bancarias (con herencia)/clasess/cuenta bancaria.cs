using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentas_bancarias__con_herencia_.clasess
{
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
    }

