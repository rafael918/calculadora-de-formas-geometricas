using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("calcula a area de um  retangulo");
            Console.Write("informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("informe a base/largura: " );
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibeDados();
            Console.ReadKey();
        }
    }
}
