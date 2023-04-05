using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Clientes_Par_impar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomesClientes = new string[6]; 
            {
                for (int i = 0; i < nomesClientes.Length; i++) 
                {
                    Console.WriteLine("Digite o Nome do Cliente;");
                    nomesClientes[i]= Console.ReadLine();
                    Console.Clear();
                }

                for (int i = 0;i < nomesClientes.Length;i++)
                {
                    if (i % 2 == 0) 
                    {                        
                        Console.WriteLine(nomesClientes[i]);                        
                    }
                }

                for (int i = 0; i < nomesClientes.Length; i++)
                {
                    if (i % 2 == 1)
                    {                       
                        Console.WriteLine(nomesClientes[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
