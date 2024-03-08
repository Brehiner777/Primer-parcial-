using Casino2;

class Program
{
    static void Main(string[] args)
    {
        // Registro del usuario
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su clave: ");
        string clave = Console.ReadLine();

        // Crear instancia de usuario
        Usuario usuario = new Usuario(nombre, clave, 5000); // Saldo inicial del usuario (simulado)

        // Crear instancia de la máquina dispensadora
        MaquinaDispensadora maquina = new MaquinaDispensadora();

        // Ingreso del valor a cambiar
        Console.Write("Ingrese el valor a cambiar (menor a 5000 pesos): ");
        double valorIngresado = double.Parse(Console.ReadLine());

        // Calcular y mostrar fichas
        maquina.CalcularFichas(valorIngresado);

        Console.WriteLine("\n¡Gracias por usar la máquina dispensadora!");
    }
}

