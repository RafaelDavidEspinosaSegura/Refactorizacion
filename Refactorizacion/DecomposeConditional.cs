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


// Se movio la condicional compleja del if a un metodo con nombre (PuedeIngresar) 
// simplifica la lectura de if
//Permite reutilizar la lógica de validación en otros lugares del código sin duplicar la condición.
//Facilita las pruebas unitarias al poder probar la lógica de validación de forma aislada.
