//Move Method sin refactorizar

class Cliente
{
    public string Nombre { get; set; }
    public int Puntos { get; set; }
}

class Program
{
    static void Main()
    {
        Cliente c = new Cliente { Nombre = "David", Puntos = 120 };
        Console.WriteLine("Nivel de cliente: " + CalcularNivel(c));
    }

    static string CalcularNivel(Cliente cliente)
    {
        if (cliente.Puntos > 100) return "Premium";
        return "Regular";
    }
}


