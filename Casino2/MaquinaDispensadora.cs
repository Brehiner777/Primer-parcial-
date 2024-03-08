using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino2
{
    public class MaquinaDispensadora
    {

        private double saldoInicial = 5000; // Saldo inicial de la máquina

        // Método para calcular las fichas a entregar
        public void CalcularFichas(double valorIngresado)
        {
            double valorRestante = saldoInicial - valorIngresado;
            int fichas1000 = (int)(valorRestante / 1000);
            valorRestante %= 1000;
            int fichas500 = (int)(valorRestante / 500);
            valorRestante %= 500;
            int fichas200 = (int)(valorRestante / 200);
            valorRestante %= 200;
            int fichas100 = (int)(valorRestante / 100);
            valorRestante %= 100;
            int fichas50 = (int)(valorRestante / 50);

            // Ajuste de valores según las reglas
            if (valorRestante >= 25 && valorRestante <= 49)
            {
                fichas50++;
            }
            else if (valorRestante >= 1 && valorRestante <= 24)
            {
                valorRestante = 0;
            }

            // Mostrar resultados
            Console.WriteLine("\nFichas entregadas:");
            Console.WriteLine($"Fichas de 1000: {fichas1000}");
            Console.WriteLine($"Fichas de 500: {fichas500}");
            Console.WriteLine($"Fichas de 200: {fichas200}");
            Console.WriteLine($"Fichas de 100: {fichas100}");
            Console.WriteLine($"Fichas de 50: {fichas50}");
            Console.WriteLine($"Valor restante: {valorRestante:C}");
        }

    }
}
