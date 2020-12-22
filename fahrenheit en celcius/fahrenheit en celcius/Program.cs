using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_en_celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, faren;
            Console.WriteLine("saisissez la température en °C : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("La conversion en °F) : " + faren);
            Console.ReadLine();
        }
    }
}
