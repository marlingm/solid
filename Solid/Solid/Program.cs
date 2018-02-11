using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            notificacion not = new notificacion();
            mensajes men = new mensajes();
            criptografia crip = new criptografia();
                

          
            Console.WriteLine(not.Enviarcorreoa());
            Console.WriteLine(not.Enviarcorreos());
            Console.WriteLine(men.registrartraza());
            Console.WriteLine(men.registrarerror());
            Console.WriteLine(crip.Encriptarobjeto());
            Console.WriteLine(crip.Desencriptar());
           
           
           
            Console.ReadKey();

        }
    }
}
