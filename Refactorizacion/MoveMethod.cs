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

// Move Method refactorizado

class Cliente
{
    public string Nombre { get; set; }
    public int Puntos { get; set; }

    public string CalcularNivel()
    {
        return Puntos > 100 ? "Premium" : "Regular";
    }
}

class Program
{
    static void Main()
    {
        Cliente c = new Cliente { Nombre = "David", Puntos = 120 };
        Console.WriteLine("Nivel de cliente: " + c.CalcularNivel());
    }
}


// Se traslado la logica de calcular desde program hacia Cliente, ya que es mas logico que el cliente sepa su nivel, ademas de que asi se evita tener que pasar el cliente como parametro cada vez que se quiera calcular su nivel.
// Con esto el calculo de nivel pertecene al cliente y no al programa principla, aplicando el principio de responsabilidad unica.
// Mejora la cohesion, haciendo que cada clase se encargue de lo que le corresponde
//facilita la extension , si cambian las reglas de nivel, se modifican en la clase cliente sin afectar al resto 

