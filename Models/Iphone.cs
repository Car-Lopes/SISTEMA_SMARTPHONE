using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SISTEMA_SMARTPHONE.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Descrever o método "InstalarAPP"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o APP {nomeApp} no IPHONE");
        }
    }
}