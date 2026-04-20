//Decompose Conditional sin refactorizar

if (edad > 18 && tieneDocumento && !estaReportado)
{
    Console.WriteLine("Puede ingresar al sistema.");
}
else
{
    Console.WriteLine("Acceso denegado.");
}


//Decompose Conditional refactorizado

if (PuedeIngresar(edad, tieneDocumento, estaReportado))
{
    Console.WriteLine("Puede ingresar al sistema.");
}
else
{
    Console.WriteLine("Acceso denegado.");
}

static bool PuedeIngresar(int edad, bool tieneDocumento, bool estaReportado)
{
    return edad > 18 && tieneDocumento && !estaReportado;
}
