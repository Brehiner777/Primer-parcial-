using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    public class Usuario
    {

        public string Nombre { get; set; }
        public string Clave { get; set; }
        public double Saldo { get; set; }

        // Constructor para inicializar los datos del usuario
        public Usuario(string nombre, string clave, double saldoInicial)
        {
            Nombre = nombre;
            Clave = clave;
            Saldo = saldoInicial;
        }

    }
}
